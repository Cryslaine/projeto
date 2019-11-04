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
    public partial class FornecedorEnderecoWeb : System.Web.UI.Page
    {
        private bool ValidarFornecedor(object obj)
        {
            var erros = Validacao.getValidationErros(obj);
            foreach (var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
                return false;
            }
            return true;


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //grupoBoxFornecedor();
                grupoBoxFornecedorEndereco();
                //grupBoxTipo();
                //camposDataGrid();
                CamposEnderecoDataGrid();
            }


            btnEditarEndereco.Visible = false;
        }
        #region "Botão"
        protected void txtSalvarEndereco_Click(object sender, EventArgs e)
        {
            ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modEF.IdFornecedor = Convert.ToInt32(ddlFornecedorEmpresa.SelectedItem.Value);
            modEF.Endereco = txtEndereco.Text;
            modEF.Bairro = txtBairro.Text;
            modEF.Numero = txtNumero.Text;
            modEF.Cidade = txtCidade.Text;
            modEF.UF = txtUf.Text;
            modEF.CEP = txtCep.Text;
            modEF.Complemento = txtComplemento.Text;

            if (!ValidarFornecedor(modEF))
            {
                return;
            }
            neg.AdicionarEndereco(modEF);
            MessageBox.Show("Formulario salvo com sucesso!");

            limparCamposEndereco();
            CamposEnderecoDataGrid();
        }

        protected void btnEditarEndereco_Click(object sender, EventArgs e)
        {
            ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modEF.Id = Convert.ToInt32(txtIdEndereco.Text);
            modEF.IdFornecedor = Convert.ToInt32(ddlFornecedorEmpresa.SelectedValue);
            modEF.Endereco = txtEndereco.Text;
            modEF.Bairro = txtBairro.Text;
            modEF.Numero = txtNumero.Text;
            modEF.Cidade = txtCidade.Text;
            modEF.UF = txtUf.Text;
            modEF.CEP = txtCep.Text;
            modEF.Complemento = txtComplemento.Text;

            if (!ValidarFornecedor(modEF))
            {
                return;
            }

            neg.AtualizarEndereco(modEF);
            MessageBox.Show("Formulario atualizado com sucesso!");

            limparCamposEndereco();
            CamposEnderecoDataGrid();
            btnEditarEndereco.Visible = false;
        }

        protected void btnCancelarEndereco_Click(object sender, EventArgs e)
        {
            limparCamposEndereco();
            btnSalvarEndereco.Visible = true;
            btnEditarEndereco.Visible = false;
        }
        #endregion

        public void grupoBoxFornecedorEndereco()
        {


            FornecedorNEG neg = new FornecedorNEG();
            List<ModFornecedor> lstModFornecedor = neg.GbFornEndereco();
            lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
            ddlFornecedorEmpresa.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
            ddlFornecedorEmpresa.DataValueField = "Id";
            ddlFornecedorEmpresa.DataTextField = "Nome";
            ddlFornecedorEmpresa.DataBind();

        }
        public void CamposEnderecoDataGrid()
        {
            FornecedorNEG neg = new FornecedorNEG();
            gvEnderecoFornecedor.DataSource =
                neg.EnderecoDataGrid().Select(a => new
                { a.Id, a.FornecedorMod.Nome, a.Endereco, a.Bairro, a.Numero, a.Cidade, a.UF, a.CEP, a.Complemento }).ToList();
            gvEnderecoFornecedor.DataBind();
        }
        private void limparCamposEndereco()
        {
            //Fornecedor.Text = string.Empty;
            ddlFornecedorEmpresa.SelectedItem.Value = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtComplemento.Text = string.Empty;

        }
        protected void gvEnderecoFornecedor_RowEditing(object sender, GridViewEditEventArgs e)
        {
            FornecedorNEG neg = new FornecedorNEG();
            ModEnderecoFornecedor modEndereco = new ModEnderecoFornecedor();


            int Primarykey = Convert.ToInt16(gvEnderecoFornecedor.DataKeys[e.NewEditIndex].Value);
            modEndereco = neg.dvSelectEnd(Primarykey);

            ddlFornecedorEmpresa.SelectedValue = Convert.ToInt32(modEndereco.IdFornecedor).ToString();
            txtIdEndereco.Text = Convert.ToInt32(modEndereco.Id).ToString();
            txtEndereco.Text = modEndereco.Endereco;
            txtBairro.Text = modEndereco.Bairro;
            txtNumero.Text = modEndereco.Numero;
            txtCidade.Text = modEndereco.Cidade;
            txtUf.Text = modEndereco.UF;
            txtCep.Text = modEndereco.CEP;
            txtComplemento.Text = modEndereco.Complemento;
            e.Cancel = true;
            gvEnderecoFornecedor.EditIndex = -1;
            btnEditarEndereco.Visible = true;
        }

        protected void gvEnderecoFornecedor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            FornecedorNEG neg = new FornecedorNEG();
            ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
            modEF.Id = Convert.ToInt32(e.Keys[0]);

            neg.DvgEndForne(Convert.ToInt32(e.Keys[0]));
            MessageBox.Show("Dado excluido com sucesso!");


            CamposEnderecoDataGrid();
            limparCamposEndereco();

        }
        protected void gvEnderecoFornecedor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEnderecoFornecedor.PageIndex = e.NewPageIndex;
            CamposEnderecoDataGrid();
        }

    }
}