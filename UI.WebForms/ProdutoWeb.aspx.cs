using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UI.WebForms
{
    public partial class ProdutoWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CampoProdutoDataGrid();
                grupoBoxFornecedor();
            }
            btnEditar.Visible = false;

        }
        private bool ValidarProduto(object obj)
        {
            var erros = Validacao.getValidationErros(obj);
            foreach (var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
                return false;
            }
            return true;

        }
        #region "Botão"
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;

            ModProduto modProduto = new ModProduto();
            ProdutoNEG negProd = new ProdutoNEG();


            modProduto.IdFornecedor = Convert.ToInt32(ddlFornecedo.SelectedValue);
            modProduto.Pro_Nome = txtNome.Text;
            modProduto.Preco = Convert.ToDouble(txtPreco.Text);
            modProduto.Preco = (modProduto.CalcularImposto(Convert.ToDouble(txtPreco.Text)) + (Convert.ToDouble(txtPreco.Text)));
            modProduto.Tamanho = Convert.ToInt32(txtTamanho.Text);
            modProduto.Peso = Convert.ToDecimal(txtPeso.Text);
            modProduto.Cor = ddlCor.Text;
            modProduto.Quantidade = Convert.ToInt32(ddlQuantidade.Text);

            if (!ValidarProduto(modProduto))
            {
                return;
            }
            negProd.SalvarProduto(modProduto);

            LimparCampos();
            btnEditar.Visible = true;

            CampoProdutoDataGrid();

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

            LimparCampos();
            btnSalvar.Visible = true;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            ModProduto modProduto = new ModProduto();
            ProdutoNEG negProd = new ProdutoNEG();

            modProduto.Id = Convert.ToInt32(txtId.Text);
            modProduto.Preco = Convert.ToDouble(txtPreco.Text);

            negProd.CalculoProduto(modProduto, Convert.ToDouble(txtPreco.Text));


            modProduto.IdFornecedor = Convert.ToInt32(ddlFornecedo.SelectedValue);
            modProduto.Pro_Nome = txtNome.Text;
            modProduto.Tamanho = Convert.ToInt32(txtTamanho.Text);
            modProduto.Peso = Convert.ToDecimal(txtPeso.Text);
            modProduto.Cor = ddlCor.Text;
            modProduto.Quantidade = Convert.ToInt32(ddlQuantidade.Text);
            modProduto.Id = Convert.ToInt32(txtId.Text);


            if (!ValidarProduto(modProduto))
            {
                return;
            }

            modProduto.Id = Convert.ToInt32(txtId.Text);
            negProd.EditarProduto(modProduto);
            MessageBox.Show("Formulario atualizado com sucesso!");

            CampoProdutoDataGrid();

            LimparCampos();

            
            btnEditar.Visible = false;
        }


        protected void btnPesquiasr_Click(object sender, EventArgs e)
        {

            ProdutoNEG negProd = new ProdutoNEG();
            ModProduto modProduto = new ModProduto();

            modProduto.Pro_Nome = txtPesquisa.Text;

            List<ModProduto> listaProduto = negProd.CampoDgProd();

            gvProduto.DataSource =
             negProd.PesquisarProduto(modProduto).Select(a => new
             { a.Id, a.IdFornecedor, a.Pro_Nome, a.Quantidade, a.Preco, a.Peso, a.Tamanho, a.Cor }).ToList();
            gvProduto.DataBind();

          
        }


        #endregion

        #region"GridView"
        protected void gvProduto_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ProdutoNEG negProd = new ProdutoNEG();
            ModProduto modProduto = new ModProduto();
            // modf.Id = Convert.ToInt32(e.Keys[0]);

            negProd.DvgProd(Convert.ToInt32(e.Keys[0]));

            MessageBox.Show("Dado excluido com sucesso!");

            CampoProdutoDataGrid(); 
        }
        protected void gvProduto_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            ProdutoNEG negProd = new ProdutoNEG();
            ModProduto modProduto = new ModProduto();


            int Primarykey = Convert.ToInt32(gvProduto.DataKeys[e.NewEditIndex].Value);
            modProduto = negProd.dvSelect(Primarykey);


            negProd.CalculoProduto(modProduto, Convert.ToDouble(modProduto.Preco));
            txtId.Text = Convert.ToInt32(modProduto.Id).ToString();
            ddlFornecedo.SelectedValue = modProduto.IdFornecedor.ToString();
            txtNome.Text = modProduto.Pro_Nome;
            txtTamanho.Text = Convert.ToInt32(modProduto.Tamanho).ToString();
            txtPeso.Text = Convert.ToDecimal(modProduto.Peso).ToString();
            ddlCor.Text = modProduto.Cor;
            ddlQuantidade.Text = Convert.ToInt32(modProduto.Quantidade).ToString();
            txtPreco.Text = Convert.ToDouble(modProduto.Preco).ToString();

            e.Cancel = true;
            gvProduto.EditIndex = -1;
            btnSalvar.Visible = false;
            btnEditar.Visible = true;
        }
        protected void CampoProdutoDataGrid()
        {

            ProdutoNEG negProd = new ProdutoNEG();
            gvProduto.DataSource =
               negProd.CampoDgProd().Select(a => new
               {
                   a.Id, a.FornMOD.Nome,a.Pro_Nome, a.Quantidade, a.Preco, a.Peso, a.Tamanho, a.Cor
               }).ToList();
            gvProduto.DataBind();
        }
        protected void gvProduto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProduto.PageIndex = e.NewPageIndex;
            CampoProdutoDataGrid();
        }
        #endregion
        public void grupoBoxFornecedor()
        {
            ProdutoNEG negProd = new ProdutoNEG();
            List<ModFornecedor> lstModFornecedor = negProd.GbFornecedor();
            lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
            ddlFornecedo.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
            ddlFornecedo.DataValueField = "Id";
            ddlFornecedo.DataTextField = "Nome";
            ddlFornecedo.DataBind();
        }
        protected void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtTamanho.Text = string.Empty;
            txtPeso.Text = string.Empty;
            ddlCor.Text = string.Empty;
            ddlQuantidade.Text = string.Empty;
            //ddlFornecedo.SelectedValue = string.Empty;
        }

       
    }
}