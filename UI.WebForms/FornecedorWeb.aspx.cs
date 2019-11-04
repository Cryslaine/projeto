using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace UI.WebForms
{
    public partial class FornecedorWeb : System.Web.UI.Page
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
               // grupoBoxFornecedorEndereco();
                //grupBoxTipo();
                //camposDataGrid();
               // CamposEnderecoDataGrid();
            }


           // btnEditarEndereco.Visible = false;


        }



        #region"Botão"

        protected void PesquisaCnpj_Click(object sender, EventArgs e)
        {

            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();
            modF = neg.PesquisarFornecedor(Regex.Replace(txtCnpjPesquisa.Text, "[^0-9a-zA-Z]+", "").Replace("/", "").Replace(".", "").Replace("-", ""));

            txtId.Text = Convert.ToInt32(modF.Id).ToString();
            txtRazaoSocial.Text = modF.RazaoSocial;
            txtNomefantasia.Text = modF.Nome;
            txtCnpj.Text = modF.Cnpj;
            if (modF.Cnpj == txtCnpjPesquisa.Text)
            {
                MessageBox.Show("Pesquisa realizada com sucesso!");
            }
            else
            {
                MessageBox.Show("CNPJ não cadastrado!");
            }


        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();


            modF.RazaoSocial = txtRazaoSocial.Text;
            modF.Nome = txtNomefantasia.Text;
            modF.Cnpj = (Regex.Replace(txtCnpj.Text, @"[^0-9]+?", ""));

            if (!ValidarFornecedor(modF))
            {
                return;
            }


            try
            {
                neg.AdicionarFor(modF);
                MessageBox.Show("Dados salvos com sucesso!");
                //grupoBoxFornecedor();
               // grupoBoxFornecedorEndereco();
                limparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modF.Id = Convert.ToInt32(txtId.Text);
            modF.RazaoSocial = txtRazaoSocial.Text;
            modF.Nome = txtNomefantasia.Text;
            modF.Cnpj = Regex.Replace(txtCnpj.Text, "[^0-9a-zA-Z]+", "");


            if (!ValidarFornecedor(modF))
            {
                return;
            }

            neg.AtualizarFornecedor(modF);
            MessageBox.Show("Formulario atualizado com sucesso!");
            limparCampos();

        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modF.Id = Convert.ToInt32(txtId.Text);
            neg.ExcluirFor(modF);

            MessageBox.Show("Dados Excluido com sucesso!");
            //grupoBoxFornecedor();
            //grupoBoxFornecedorEndereco();
            limparCampos();

        }

        //protected void btnSalvarTel_Click(object sender, EventArgs e)
        //{
        //    ModFornecedorTelefone modTF = new ModFornecedorTelefone();
        //    FornecedorNEG neg = new FornecedorNEG();


        //    modTF.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedItem.Value) };

        //    modTF.IdFornecedor = Convert.ToInt32(ddlFornecedoTel.SelectedItem.Value);

        //    modTF.Telefone = txtTelefone.Text;//.Replace("()", "").Replace("-", "")


        //    if (!ValidarFornecedor(modTF))
        //    {
        //        return;
        //    }

        //    neg.AdicionarTel(modTF);
        //    MessageBox.Show("Formulario salvos com sucesso!");

        //    camposDataGrid();
        //    limparCamposTelefone();
        //}

        //protected void btnEditarTel_Click(object sender, EventArgs e)
        //{
        //    ModFornecedorTelefone modTF = new ModFornecedorTelefone();
        //    FornecedorNEG neg = new FornecedorNEG();

        //    modTF.Id = Convert.ToInt32(txtIdTel.Text);
        //    modTF.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedValue) };
        //    modTF.IdFornecedor = Convert.ToInt32(ddlFornecedoTel.SelectedValue);
        //    modTF.Telefone = txtTelefone.Text;


        //    if (!ValidarFornecedor(modTF))
        //    {
        //        return;
        //    }

        //    neg.AtualizarTel(modTF);
        //    MessageBox.Show("Formulario atualizado com sucesso!");
        //    camposDataGrid();
        //    limparCamposTelefone();
        //}

        //protected void btnCancelarTel_Click(object sender, EventArgs e)
        //{
        //    limparCamposTelefone();
        //    btnSalvarTel.Visible = true;
        //    btnEditarTel.Visible = false;
        //}

        //protected void txtSalvarEndereco_Click(object sender, EventArgs e)
        //{
        //    ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
        //    FornecedorNEG neg = new FornecedorNEG();

        //    modEF.IdFornecedor = Convert.ToInt32(ddlFornecedorEmpresa.SelectedItem.Value);
        //    modEF.Endereco = txtEndereco.Text;
        //    modEF.Bairro = txtBairro.Text;
        //    modEF.Numero = txtNumero.Text;
        //    modEF.Cidade = txtCidade.Text;
        //    modEF.UF = txtUf.Text;
        //    modEF.CEP = txtCep.Text;
        //    modEF.Complemento = txtComplemento.Text;

        //    if (!ValidarFornecedor(modEF))
        //    {
        //        return;
        //    }
        //    neg.AdicionarEndereco(modEF);
        //    MessageBox.Show("Formulario salvo com sucesso!");

        //    limparCamposEndereco();
        //    CamposEnderecoDataGrid();
        //}

        //protected void btnEditarEndereco_Click(object sender, EventArgs e)
        //{
        //    ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
        //    FornecedorNEG neg = new FornecedorNEG();

        //    modEF.Id = Convert.ToInt32(txtIdEndereco.Text);
        //    modEF.IdFornecedor = Convert.ToInt32(ddlFornecedorEmpresa.SelectedValue);
        //    modEF.Endereco = txtEndereco.Text;
        //    modEF.Bairro = txtBairro.Text;
        //    modEF.Numero = txtNumero.Text;
        //    modEF.Cidade = txtCidade.Text;
        //    modEF.UF = txtUf.Text;
        //    modEF.CEP = txtCep.Text;
        //    modEF.Complemento = txtComplemento.Text;

        //    if (!ValidarFornecedor(modEF))
        //    {
        //        return;
        //    }

        //    neg.AtualizarEndereco(modEF);
        //    MessageBox.Show("Formulario atualizado com sucesso!");

        //    limparCamposEndereco();
        //    CamposEnderecoDataGrid();
        //    btnEditarEndereco.Visible = false;
        //}

        //protected void btnCancelarEndereco_Click(object sender, EventArgs e)
        //{
        //    limparCamposEndereco();
        //    btnSalvarEndereco.Visible = true;
        //    btnEditarEndereco.Visible = false;
        //}
        #endregion


        #region "Lista de GrupBox"
        //public void grupBoxTipo()
        //{

        //    FornecedorNEG neg = new FornecedorNEG();
        //    List<TipoTelefone> lstTipoTelefone = neg.GbTipo();
        //    lstTipoTelefone.Add(new TipoTelefone { Id = 0, Descricao = "Selecione..." });
        //    ddlTipo.DataSource = lstTipoTelefone.OrderBy(o => o.Id).ToList();
        //    ddlTipo.DataValueField = "Id";
        //    ddlTipo.DataTextField = "Descricao";
        //    ddlTipo.DataBind();

        //}
        //public void grupoBoxFornecedor()
        //{
        //    FornecedorNEG neg = new FornecedorNEG();
        //    List<ModFornecedor> lstModFornecedor = neg.GbFornecedor();
        //    lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
        //    ddlFornecedoTel.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
        //    ddlFornecedoTel.DataValueField = "Id";
        //    ddlFornecedoTel.DataTextField = "Nome";
        //    ddlFornecedoTel.DataBind();

        //}
        //public void grupoBoxFornecedorEndereco()
        //{


        //    FornecedorNEG neg = new FornecedorNEG();
        //    List<ModFornecedor> lstModFornecedor = neg.GbFornEndereco();
        //    lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
        //    ddlFornecedorEmpresa.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
        //    ddlFornecedorEmpresa.DataValueField = "Id";
        //    ddlFornecedorEmpresa.DataTextField = "Nome";
        //    ddlFornecedorEmpresa.DataBind();

        //}
        #endregion

        #region " Posição e informações do DataGrid"
        //public void camposDataGrid()
        //{

        //    FornecedorNEG neg = new FornecedorNEG();
        //    gvTelefoneFornecedor.DataSource =
        //       neg.TelefoneDataGrid().
        //       Select(a => new { a.Id, a.FornecedorMod.Nome, a.Telefone, a.Tipo.Descricao }).ToList();
        //    gvTelefoneFornecedor.DataBind();


        //}
        //public void CamposEnderecoDataGrid()
        //{
        //    FornecedorNEG neg = new FornecedorNEG();
        //    gvEnderecoFornecedor.DataSource =
        //        neg.EnderecoDataGrid().Select(a => new
        //        { a.Id, a.FornecedorMod.Nome , a.Endereco, a.Bairro, a.Numero, a.Cidade, a.UF, a.CEP, a.Complemento }).ToList();
        //    gvEnderecoFornecedor.DataBind();
        //}


        #endregion




        #region"Limpar campos " 
        private void limparCampos()
        {
            txtRazaoSocial.Text = string.Empty;
            txtNomefantasia.Text = string.Empty;
            txtCnpj.Text = string.Empty;

        }
        //private void limparCamposEndereco()
        //{
        //    Fornecedor.Text = string.Empty;
        //    ddlFornecedorEmpresa.SelectedItem.Value = string.Empty;
        //    txtEndereco.Text = string.Empty;
        //    txtBairro.Text = string.Empty;
        //    txtNumero.Text = string.Empty;
        //    txtCidade.Text = string.Empty;
        //    txtUf.Text = string.Empty;
        //    txtCep.Text = string.Empty;
        //    txtComplemento.Text = string.Empty;

        //}

        //public void limparCamposTelefone()
        //{
        //    txtIdTel.Text = string.Empty;
        //    // ddlTipo.Text = string.Empty;
        //    txtTelefone.Text = string.Empty;
        //    Fornecedor.Text = string.Empty;
        //}
        //#endregion

        //#region "GridView"
        //protected void gvTelefoneFornecedor_RowEditing2(object sender, GridViewEditEventArgs e)
        //{
        //    FornecedorNEG neg = new FornecedorNEG();
        //    ModFornecedorTelefone modTF = new ModFornecedorTelefone();

        //    int Primarykey = Convert.ToInt16(gvTelefoneFornecedor.DataKeys[e.NewEditIndex].Value);

        //    modTF = neg.dvSelect(Primarykey);
        //    txtIdTel.Text = Convert.ToInt32(modTF.Id).ToString();
        //    txtTelefone.Text = modTF.Telefone;
        //    ddlTipo.SelectedValue = modTF.Tipo.Id.ToString();
        //    ddlFornecedoTel.SelectedValue = Convert.ToInt32(modTF.IdFornecedor).ToString();
        //    e.Cancel = true;
        //    gvTelefoneFornecedor.EditIndex = -1;
        //    btnEditarTel.Visible = true;
        //}

        //protected void gvTelefoneFornecedor_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        //{
        //    FornecedorNEG neg = new FornecedorNEG();
        //    ModFornecedor modf = new ModFornecedor();
        //    // modf.Id = Convert.ToInt32(e.Keys[0]);

        //    neg.DvgTelForneDelet(Convert.ToInt32(e.Keys[0]));

        //    MessageBox.Show("Dado excluido com sucesso!");

        //    camposDataGrid();
        //}

        
        //protected void gvEnderecoFornecedor_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    FornecedorNEG neg = new FornecedorNEG();
        //    ModEnderecoFornecedor modEndereco = new ModEnderecoFornecedor();

         
        //    int Primarykey = Convert.ToInt16(gvEnderecoFornecedor.DataKeys[e.NewEditIndex].Value);
        //    modEndereco = neg.dvSelectEnd(Primarykey);

        //    ddlFornecedorEmpresa.SelectedValue = Convert.ToInt32(modEndereco.IdFornecedor).ToString();
        //    txtIdEndereco.Text = Convert.ToInt32(modEndereco.Id).ToString();
        //    txtEndereco.Text = modEndereco.Endereco;
        //    txtBairro.Text = modEndereco.Bairro;
        //    txtNumero.Text = modEndereco.Numero;
        //    txtCidade.Text = modEndereco.Cidade;
        //    txtUf.Text = modEndereco.UF;
        //    txtCep.Text = modEndereco.CEP;
        //    txtComplemento.Text = modEndereco.Complemento;
        //    e.Cancel = true;
        //    gvEnderecoFornecedor.EditIndex = -1;
        //    btnEditarEndereco.Visible = true;
        //}

        //protected void gvEnderecoFornecedor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    FornecedorNEG neg = new FornecedorNEG();
        //    ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
        //    modEF.Id = Convert.ToInt32(e.Keys[0]);

        //    neg.DvgEndForne(Convert.ToInt32(e.Keys[0]));
        //    MessageBox.Show("Dado excluido com sucesso!");


        //    CamposEnderecoDataGrid();
        //    limparCamposEndereco();

        //}

        //protected void gvTelefoneFornecedor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    gvTelefoneFornecedor.PageIndex = e.NewPageIndex;
        //    camposDataGrid();
        //   // gvTelefoneFornecedor.DataBind();
        //}

        //protected void gvEnderecoFornecedor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    gvEnderecoFornecedor.PageIndex = e.NewPageIndex;
        //    camposDataGrid();
        //}
        #endregion

        protected void gvTelefoneFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

