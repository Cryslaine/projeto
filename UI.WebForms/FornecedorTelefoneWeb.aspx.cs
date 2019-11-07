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
    public partial class TelefoneFornecedorWeb : System.Web.UI.Page
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
                grupoBoxFornecedor();
                // grupoBoxFornecedorEndereco();
                grupBoxTipo();
                camposDataGrid();
                // CamposEnderecoDataGrid();
            }
        }
        protected void btnSalvarTel_Click(object sender, EventArgs e)
        {
            ModFornecedorTelefone modTF = new ModFornecedorTelefone();
            FornecedorNEG neg = new FornecedorNEG();


            modTF.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedItem.Value) };

            modTF.IdFornecedor = Convert.ToInt32(ddlFornecedoTel.SelectedItem.Value);

            modTF.Telefone = txtTelefone.Text;//.Replace("()", "").Replace("-", "")


            if (!ValidarFornecedor(modTF))
            {
                return;
            }

            neg.AdicionarTel(modTF);
            MessageBox.Show("Formulario salvos com sucesso!");

            camposDataGrid();
            limparCamposTelefone();
        }

        protected void btnEditarTel_Click(object sender, EventArgs e)
        {
            ModFornecedorTelefone modTF = new ModFornecedorTelefone();
            FornecedorNEG neg = new FornecedorNEG();

            modTF.Id = Convert.ToInt32(txtIdTel.Text);
            modTF.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedValue) };
            modTF.IdFornecedor = Convert.ToInt32(ddlFornecedoTel.SelectedValue);
            modTF.Telefone = txtTelefone.Text;


            if (!ValidarFornecedor(modTF))
            {
                return;
            }

            neg.AtualizarTel(modTF);
            MessageBox.Show("Formulario atualizado com sucesso!");
            camposDataGrid();
            limparCamposTelefone();
        }

        protected void btnCancelarTel_Click(object sender, EventArgs e)
        {
            limparCamposTelefone();
            btnSalvarTel.Visible = true;
            btnEditarTel.Visible = false;
        }
        public void grupBoxTipo()
        {

            FornecedorNEG neg = new FornecedorNEG();
            List<TipoTelefone> lstTipoTelefone = neg.GbTipo();
            lstTipoTelefone.Add(new TipoTelefone { Id = 0, Descricao = "Selecione..." });
            ddlTipo.DataSource = lstTipoTelefone.OrderBy(o => o.Id).ToList();
            ddlTipo.DataValueField = "Id";
            ddlTipo.DataTextField = "Descricao";
            ddlTipo.DataBind();

        }
        public void camposDataGrid()
        {

            FornecedorNEG neg = new FornecedorNEG();
            gvTelefoneFornecedor.DataSource =
               neg.TelefoneDataGrid().
               Select(a => new { a.Id, a.FornecedorMod.Nome, a.Telefone, a.Tipo.Descricao }).ToList();
            gvTelefoneFornecedor.DataBind();


        }
        public void limparCamposTelefone()
        {
            txtIdTel.Text = string.Empty;
            // ddlTipo.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            Fornecedor.Text = string.Empty;
        }


        
        protected void gvTelefoneFornecedor_RowEditing2(object sender, GridViewEditEventArgs e)
        {
            FornecedorNEG neg = new FornecedorNEG();
            ModFornecedorTelefone modTF = new ModFornecedorTelefone();

            int Primarykey = Convert.ToInt16(gvTelefoneFornecedor.DataKeys[e.NewEditIndex].Value);

            modTF = neg.dvSelect(Primarykey);
            txtIdTel.Text = Convert.ToInt32(modTF.Id).ToString();
            txtTelefone.Text = modTF.Telefone;
            ddlTipo.SelectedValue = modTF.Tipo.Id.ToString();
            ddlFornecedoTel.SelectedValue = Convert.ToInt32(modTF.IdFornecedor).ToString();
            e.Cancel = true;
            gvTelefoneFornecedor.EditIndex = -1;
            btnEditarTel.Visible = true;
        }
        protected void gvTelefoneFornecedor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTelefoneFornecedor.PageIndex = e.NewPageIndex;
            camposDataGrid();
            // gvTelefoneFornecedor.DataBind();
        }
        protected void gvTelefoneFornecedor_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            FornecedorNEG neg = new FornecedorNEG();
            ModFornecedor modf = new ModFornecedor();
            // modf.Id = Convert.ToInt32(e.Keys[0]);

            neg.DvgTelForneDelet(Convert.ToInt32(e.Keys[0]));

            MessageBox.Show("Dado excluido com sucesso!");

            camposDataGrid();
        }

        public void grupoBoxFornecedor()
        {
            FornecedorNEG neg = new FornecedorNEG();
            List<ModFornecedor> lstModFornecedor = neg.GbFornecedor();
            lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
            ddlFornecedoTel.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
            ddlFornecedoTel.DataValueField = "Id";
            ddlFornecedoTel.DataTextField = "Nome";
            ddlFornecedoTel.DataBind();

        }

     
    }
}