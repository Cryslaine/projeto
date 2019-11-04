using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UI.Web
{
    public partial class Empresa : System.Web.UI.Page
    {
        private bool ValidarEmpresa(object obj)
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
            List<ModEmpresa> modEmpresa = new List<ModEmpresa>();
            EmpresaNEG negEmp = new EmpresaNEG();
            modEmpresa = negEmp.Load();

            foreach (var item in modEmpresa)
            {
                preenchimentoCampos(item);

            }

            //estando preenchido o botão e desativado
            if (modEmpresa.Count > 0)
            {
                habilitardesabilitar(false);
            }

            //Populando ComboBox Tipo
            grupBoxTipos();
            //populando DataGridView
            camposDataGrid();
            BtnEditarTelefone.Visible = false;
            GvtelefoneEmpresa.AutoGenerateColumns = true;
            GvtelefoneEmpresa.DataBind();
            ddlTipo.DataBind();

        }

        protected void TxtCnpjPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
        #region "Botao"
        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            ModEmpresa modEmpresa = new ModEmpresa();
            EmpresaNEG negEmp = new EmpresaNEG();



            modEmpresa.NomeRazaoSocial = txtRazaoSocial.Text;
            modEmpresa.NomeFantasia = txtNomeFantasia.Text;
            modEmpresa.Cnpj = Regex.Replace(txtCnpj.Text, "[^0-9a-zA-Z]+", "");
            modEmpresa.Endereco = txtEndereco.Text;
            modEmpresa.Numero = txtN.Text;
            modEmpresa.Bairro = txtBairro.Text;
            modEmpresa.Cidade = txtCidade.Text;
            modEmpresa.UF = txtUf.Text;
            modEmpresa.CEP = txtCep.Text;
            modEmpresa.Complemento = txtComplemento.Text;

            if (!ValidarEmpresa(modEmpresa))
            {
                return;
            }


            negEmp.SalvarEmpresa(modEmpresa);
            MessageBox.Show("Dados inserido com sucesso!");

            //Campos ativos
            habilitardesabilitar(false);
        }
        

        protected void BtnEditar_Click(object sender, EventArgs e)
        {

            EmpresaNEG negEmp = new EmpresaNEG();
            ModEmpresa modEmpresa = new ModEmpresa();

            modEmpresa.NomeRazaoSocial = txtRazaoSocial.Text;
            modEmpresa.NomeFantasia = txtNomeFantasia.Text;
            modEmpresa.Cnpj = Regex.Replace(txtCnpj.Text, "[^0-9a-zA-Z]+", "");
            modEmpresa.Endereco = txtEndereco.Text;
            modEmpresa.Numero = txtN.Text;
            modEmpresa.Bairro = txtBairro.Text;
            modEmpresa.Cidade = txtCidade.Text;
            modEmpresa.UF = txtUf.Text;
            modEmpresa.CEP = txtCep.Text;
            modEmpresa.Complemento = txtComplemento.Text;

            if (!ValidarEmpresa(modEmpresa))
            {
                return;
            }
            negEmp.AtualizarEmpresa(modEmpresa);
            MessageBox.Show("Dados atualizados com sucesso!");
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitardesabilitar(true);
        }
        

        protected void BtnSalvarTelefone_Click(object sender, EventArgs e)
        {

            ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            EmpresaNEG negEmp = new EmpresaNEG();

            modTE.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedValue) };
            modTE.IdEmpresa = Convert.ToInt32(txtIdEmp.Text);
            modTE.Telefone = txtNumeroTelefone.Text;

            if (!ValidarEmpresa(modTE))
            {
                return;
            }

            negEmp.SalvarTelefoneEmpresa(modTE);
            MessageBox.Show("Formulario salvo com sucesso!");

            camposDataGrid();
            limparCamposTelefone();
        }

        protected void BtnEditarTelefeone_Click(object sender, EventArgs e)
        {
            ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            EmpresaNEG negEmp = new EmpresaNEG();

            modTE.Id = Convert.ToInt32(txtId.Text);
            modTE.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedValue) };
            modTE.IdEmpresa = Convert.ToInt32(txtIdEmp.Text);
            modTE.Telefone = txtNumeroTelefone.Text;

            if (!ValidarEmpresa(modTE))
            {
                return;
            }
            negEmp.EditarTelefoneEmpresa(modTE);
            MessageBox.Show("Formulario atualizado com sucesso!");
            camposDataGrid();
            limparCamposTelefone();
            BtnSalvarTelefone.Visible = false;

        }

        protected void BtnCancelarTelefone_Click(object sender, EventArgs e)
        {
            limparCamposTelefone();
            BtnSalvarTelefone.Visible = true;
            BtnEditarTelefone.Visible = false;
        }
        #endregion

        #region "Limpar/Preencher/Habilitar : Campos"
        private void habilitardesabilitar(bool tipo)
        {
            txtId.Enabled = tipo;
            txtNomeFantasia.Enabled = tipo;
            txtRazaoSocial.Enabled = tipo;
            txtCnpj.Enabled = tipo;
            txtEndereco.Enabled = tipo;
            txtN.Enabled = tipo;
            txtBairro.Enabled = tipo;
            txtCidade.Enabled = tipo;
            txtUf.Enabled = tipo;
            txtCep.Enabled = tipo;
            txtComplemento.Enabled = tipo;
            BtnSalvar.Enabled = tipo;
        }

        private void preenchimentoCampos(ModEmpresa modEmpresa)
        {

            txtNomeFantasia.Text = modEmpresa == null ? string.Empty : modEmpresa.NomeFantasia;
            txtRazaoSocial.Text = modEmpresa == null ? string.Empty : modEmpresa.NomeRazaoSocial;
            txtCnpj.Text = modEmpresa == null ? string.Empty : modEmpresa.Cnpj;
            txtEndereco.Text = modEmpresa == null ? string.Empty : modEmpresa.Endereco;
            txtN.Text = modEmpresa == null ? string.Empty : modEmpresa.Numero;
            txtBairro.Text = modEmpresa == null ? string.Empty : modEmpresa.Bairro;
            txtCidade.Text = modEmpresa == null ? string.Empty : modEmpresa.Cidade;
            txtUf.Text = modEmpresa == null ? string.Empty : modEmpresa.UF;
            txtCep.Text = modEmpresa == null ? string.Empty : modEmpresa.CEP;
            txtComplemento.Text = modEmpresa == null ? string.Empty : modEmpresa.Complemento;
            txtIdEmp.Text = Convert.ToString(modEmpresa.Id);
            // txtId.Text = modEmpresa == null ? string.Empty : Convert.ToString(modEmpresa.Id); ;

        }
        private void limparCamposTelefone()
        {
            ddlTipo.Text = string.Empty;
            txtNumeroTelefone.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        #endregion
        public void camposDataGrid()
        {

            EmpresaNEG negEmp = new EmpresaNEG();
            GvtelefoneEmpresa.DataSource =
                negEmp.CamposTelefoneDataGrid(Convert.ToInt32(txtIdEmp.Text))
                .Select(a => new { a.Id, a.Telefone, a.Tipo.Descricao }).ToList();


        }

        public void grupBoxTipos()
        {

            //Tras os itens cadastrados no banco e acrescrenta um novo item a lista ...

            EmpresaNEG negEmp = new EmpresaNEG();
            List<TipoTelefone> lstTipoTelefone = negEmp.GrupoBobTipoTelefone();
            lstTipoTelefone.Add(new TipoTelefone { });
            ddlTipo.DataSource = lstTipoTelefone.OrderBy(o => o.Id).ToList();

            ddlTipo.DataBind();

        }
    }

}