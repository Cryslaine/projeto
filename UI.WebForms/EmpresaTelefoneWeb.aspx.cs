﻿using Modelo;
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

    public partial class EmpresaTelefoneWeb : System.Web.UI.Page
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

            grupBoxTipos();

            camposDataGrid();


            
           
            btnEditarTelefone.Enabled = false;

        }


        protected void btnSalvarTelefone_Click(object sender, EventArgs e)
        {
            ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            EmpresaNEG negEmp = new EmpresaNEG();

            modTE.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedValue) };
            modTE.IdEmpresa = Convert.ToInt32(txtIdEmpresa.Text);
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

        protected void btnEditarTelefone_Click(object sender, EventArgs e)
        {
            ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            EmpresaNEG negEmp = new EmpresaNEG();

            modTE.Id = Convert.ToInt32(txtIdEmpresa.Text);
            modTE.Tipo = new TipoTelefone { Id = Convert.ToInt32(ddlTipo.SelectedValue) };
            modTE.IdEmpresa = Convert.ToInt32(txtIdEmpresa.Text);
            modTE.Telefone = txtNumeroTelefone.Text;

            if (!ValidarEmpresa(modTE))
            {
                return;
            }
            negEmp.EditarTelefoneEmpresa(modTE);
            MessageBox.Show("Formulario atualizado com sucesso!");
            camposDataGrid();
            limparCamposTelefone();
            btnEditarTelefone.Enabled = false;
        }

        protected void btnCancelarTelefone_Click(object sender, EventArgs e)
        {
            limparCamposTelefone();
            btnSalvarTelefone.Enabled = false;
            btnEditarTelefone.Enabled = true;
        }
        private void preenchimentoCampos(ModEmpresa modEmpresa)
        {

            //txtNomeFantasia.Text = modEmpresa == null ? string.Empty : modEmpresa.NomeFantasia;
            //txtRazaoSocial.Text = modEmpresa == null ? string.Empty : modEmpresa.NomeRazaoSocial;
            //txtCnpj.Text = modEmpresa == null ? string.Empty : modEmpresa.Cnpj;
            //txtEndereco.Text = modEmpresa == null ? string.Empty : modEmpresa.Endereco;
            //txtN.Text = modEmpresa == null ? string.Empty : modEmpresa.Numero;
            //txtBairro.Text = modEmpresa == null ? string.Empty : modEmpresa.Bairro;
            //txtCidade.Text = modEmpresa == null ? string.Empty : modEmpresa.Cidade;
            //txtUf.Text = modEmpresa == null ? string.Empty : modEmpresa.UF;
            //txtCep.Text = modEmpresa == null ? string.Empty : modEmpresa.CEP;
            //txtComplemento.Text = modEmpresa == null ? string.Empty : modEmpresa.Complemento;
            //txtId.Text = Convert.ToString(modEmpresa.Id);
            txtIdEmpresa.Text = modEmpresa == null ? string.Empty : Convert.ToString(modEmpresa.Id);

        }
        public void camposDataGrid()
        {

            EmpresaNEG negEmp = new EmpresaNEG();
            gvTelefoneEmpresa.DataSource =
                negEmp.CamposTelefoneDataGrid(Convert.ToInt32(txtId.Text)).Select(a => new
                { a.Id, a.Tipo.Descricao, a.Telefone }).ToList();

            gvTelefoneEmpresa.DataBind();
        }
        protected void gvTelefoneEmpresa_RowEditing(object sender, GridViewEditEventArgs e)
        {
            EmpresaNEG negEmp = new EmpresaNEG();
            ModEmpresaTelefone modTE = new ModEmpresaTelefone();

            int Primarykey = Convert.ToInt16(gvTelefoneEmpresa.DataKeys[e.NewEditIndex].Value);

            modTE = negEmp.dvSelecionarPorId(Primarykey);

            ddlTipo.SelectedValue = modTE.Tipo.Id.ToString();
            txtIdEmpresa.Text = Convert.ToInt32(modTE.Id).ToString();
            txtNumeroTelefone.Text = modTE.Telefone;

            btnEditarTelefone.Enabled = true;
            btnSalvarTelefone.Enabled = false;

            // e.Cancel = true;
            gvTelefoneEmpresa.EditIndex = -1;

        }

        protected void gvTelefoneEmpresa_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            EmpresaNEG negEmp = new EmpresaNEG();
            ModEmpresaTelefone modTE = new ModEmpresaTelefone();

            negEmp.DataGridCell(Convert.ToInt32(e.Keys[0]));

            MessageBox.Show("Dado excluido com sucesso!");

            camposDataGrid();
        }

        protected void gvTelefoneEmpresa_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvTelefoneEmpresa.EditIndex = -1;
            DataBind();
        }

        protected void gvTelefoneEmpresa_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTelefoneEmpresa.PageIndex = e.NewPageIndex;
            camposDataGrid();
        }
        public void grupBoxTipos()
        {

            //Tras os itens cadastrados no banco e acrescrenta um novo item a lista ...

            EmpresaNEG negEmp = new EmpresaNEG();
            List<TipoTelefone> lstTipoTelefone = negEmp.GrupoBobTipoTelefone();
            lstTipoTelefone.Add(new TipoTelefone { Id = 0, Descricao = "Selecione..." });
            ddlTipo.DataSource = lstTipoTelefone.OrderBy(o => o.Id).ToList();
            ddlTipo.DataValueField = "Id";
            ddlTipo.DataTextField = "Descricao";
            ddlTipo.DataBind();

        }




        private void limparCamposTelefone()
        {
            ddlTipo.SelectedItem.Value = string.Empty;
            txtNumeroTelefone.Text = string.Empty;
            //txtId.Text = string.Empty;
        }
    }
}