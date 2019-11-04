﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using Modelo;
using Negocio;
using System.Data;
using Microsoft.AspNetCore.Http;
using TextBox = System.Web.UI.WebControls.TextBox;

namespace UI.WebForms
{
    public partial class EmpresaUI : System.Web.UI.Page
    {

        int idFornTel;

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

        protected void GvtelefoneEmpresa_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "SendMail") return;
            int id = Convert.ToInt32(e.CommandArgument);
            
        }

        protected void GvtelefoneEmpresa_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            EmpresaNEG negEmp = new EmpresaNEG();
            ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            //if (e.CommandName == "AddToCart")
            //{
            //    int index = Convert.ToInt32(e.CommandArgument);
            //    GridViewRow row = GvtelefoneEmpresa.Rows[index];
            //    ddlTipo.Text = Convert.ToString(index);



            //}


            if (e.CommandName == "Editar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GvtelefoneEmpresa.Rows[index];
                Session["Id"] = row.Cells[4].Text;

                
            }
            if(e.CommandName == "Excluir")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GvtelefoneEmpresa.Rows[index];
                int id = Convert.ToInt32(row.Cells[4].Text);
                
            }
        }

        protected void GvtelefoneEmpresa_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvtelefoneEmpresa.EditIndex = e.NewEditIndex;
            BindData();
        }

        private void BindData()
        {
            GvtelefoneEmpresa.DataSource = Session["TaskTable"];
            GvtelefoneEmpresa.DataBind();
        }

        protected void TxtCnpjPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        //protected void GvtelefoneEmpresa_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    DataTable dt = (DataTable)Session["TaskTable"];
        //    GridViewRow row = GvtelefoneEmpresa.Rows[e.RowIndex];
        //    dt.Rows[row.DataItemIndex]["Tipo"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
        //    dt.Rows[row.DataItemIndex]["Telefone"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
        //    GvtelefoneEmpresa.EditIndex = -1;
        //    BindData();

        //}
    }
}



        