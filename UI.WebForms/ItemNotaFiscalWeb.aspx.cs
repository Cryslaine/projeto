using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UI.WebForms
{
    public partial class tester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //grupoBoxProduto();
                //grupoBoxFornecedor();
                grupoBoxNotaFical();
                grupoBoxItem();
                camposDataGrid();
            }
            btnEditarItem.Visible = false;
        }
        private bool ValidarNota(object obj)
        {
            var erros = Validacao.getValidationErros(obj);
            foreach (var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
                return false;
            }
            return true;

        }
   
        protected void btnSalvarItem_Click(object sender, EventArgs e)
        {
            ModItemNotaFiscal modItemNotaFiscal = new ModItemNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();
            ModProduto modProduto = new ModProduto();

            modItemNotaFiscal.IdNotaFiscal = Convert.ToInt32(ddlIdNotaFiscal.Text);
            //////modItemNotaFiscal.Quantidade = Convert.ToInt32(ddlQuantidade.Text);
            modItemNotaFiscal.IdProduto = Convert.ToInt32(ddlItemProduto.SelectedValue);
            modProduto = new ModProduto(Convert.ToDouble(Regex.Replace(txtValorItem.Text, "[^0-9,]+", "")));
            modItemNotaFiscal.Valor = modProduto.PrecoVenda;


            if (!ValidarNota(modItemNotaFiscal))
            {
                return;
            }

            negNota.SalvarItem(modItemNotaFiscal);
            MessageBox.Show("Dados inserido com sucesso!");


            LimparCamposItens();
            camposDataGrid();
            btnEditarItem.Visible = true;
            ddlIdNotaFiscal.Enabled = true;

        }

        protected void btnEditarItem_Click(object sender, EventArgs e)
        {
            ModItemNotaFiscal modItemNotaFiscal = new ModItemNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();
            ModProduto modProduto = new ModProduto();

            modItemNotaFiscal.Id = Convert.ToInt32(txtIdItemNotaFiscal.Text);
            modItemNotaFiscal.IdNotaFiscal = Convert.ToInt32(ddlIdNotaFiscal.Text);
            modItemNotaFiscal.Valor = Convert.ToDouble(txtValorItem.Text);

            negNota.ValidarValor(modItemNotaFiscal, Convert.ToDouble(Regex.Replace(txtValorItem.Text, "[^0-9,]+", "")));

            modItemNotaFiscal.IdNotaFiscal = Convert.ToInt32(ddlIdNotaFiscal.Text);
            modItemNotaFiscal.Quantidade = Convert.ToInt32(ddlQuantidade.Text);
            modItemNotaFiscal.IdProduto = Convert.ToInt32(ddlItemProduto.SelectedValue);
            modProduto = new ModProduto(Convert.ToDouble(Regex.Replace(txtValorItem.Text, "[^0-9,]+", "")));
            if (!ValidarNota(modItemNotaFiscal))
            {
                return;
            }

            negNota.AtualizarItemNota(modItemNotaFiscal);

            MessageBox.Show("Dados atualizados com sucesso!");

            camposDataGrid();
            LimparCamposItens();
            btnSalvarItem.Visible = true;
            btnEditarItem.Visible = false;
        }
        protected void btnExcluirItem_Click(object sender, EventArgs e)
        {
            LimparCamposItens();
            btnSalvarItem.Visible = true;
            btnEditarItem.Visible = false;
            ddlIdNotaFiscal.Enabled = true;
        }
        #region "GridView"
        protected void gvItemdaNota_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ModItemNotaFiscal modItemNotaFiscal = new ModItemNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();
            // modf.Id = Convert.ToInt32(e.Keys[0]);

            negNota.DvgItem(Convert.ToInt32(e.Keys[0]));

            MessageBox.Show("Dado excluido com sucesso!");

            camposDataGrid();
        }

        protected void gvItemdaNota_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ////gvItemdaNota.DataKeys[e.Cancel]();
            ModItemNotaFiscal modItemNotaFiscal = new ModItemNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();
            ModProduto modProduto = new ModProduto();
            int Primarykey = Convert.ToInt16(gvItemdaNota.DataKeys[e.NewEditIndex].Value);
            modItemNotaFiscal = negNota.dvSelectId(Primarykey);
            txtIdItemNotaFiscal.Text = modItemNotaFiscal.Id.ToString();
            ddlIdNotaFiscal.Text = modItemNotaFiscal.IdNotaFiscal.ToString();
            //ddlQuantidade.Text = modItemNotaFiscal.Quantidade.ToString();
            ddlQuantidade.SelectedValue = modItemNotaFiscal.Quantidade.ToString();
            ddlItemProduto.SelectedValue = modItemNotaFiscal.IdProduto.ToString();
            txtValorItem.Text = modItemNotaFiscal.Valor.ToString();
            btnEditarItem.Visible = true;
            e.Cancel = true;
            gvItemdaNota.EditIndex = -1;


        }
        public void camposDataGrid()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();
            gvItemdaNota.DataSource = negNota.DataGrid().
                Select(a => new { a.Id, a.NotaFiscal.Numero, a.Produto.Pro_Nome, a.Quantidade, a.Valor }).ToList();
            gvItemdaNota.DataBind();
        }

        protected void gvItemdaNota_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvItemdaNota.PageIndex = e.NewPageIndex;
            camposDataGrid();
        }

        protected void gvItemdaNota_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            gvItemdaNota.PageIndex = e.NewPageIndex;
            camposDataGrid();
        }
        #endregion

        private void LimparCamposItens()
        {
            txtIdItemNotaFiscal.Text = string.Empty;
            ddlIdNotaFiscal.ClearSelection();
            ddlItemProduto.ClearSelection();
            ddlQuantidade.ClearSelection();
            txtValorItem.Text = string.Empty;
        }
        #region "GrupBox"
        public void grupoBoxNotaFical()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();

            List<ModNotaFiscal> lstModNotaFiscal = negNota.GbNotaFiscal();
            lstModNotaFiscal.Add(new ModNotaFiscal { Id = 0, Numero = "Selecione..." });
            ddlIdNotaFiscal.DataSource = lstModNotaFiscal.OrderBy(o => o.Id).ToList();
            ddlIdNotaFiscal.DataValueField = "Id";
            ddlIdNotaFiscal.DataTextField = "Numero";
            ddlIdNotaFiscal.DataBind();


        }
        //public void grupoBoxProduto()
        //{
        //    NotaFicalNEG negNota = new NotaFicalNEG();

        //    List<ModProduto> lstModProduto = negNota.GbProduto();
        //    lstModProduto.Add(new ModProduto { Id = 0, Pro_Nome = "Selecione..." });
        //    ddlProduto.DataSource = lstModProduto.OrderBy(o => o.Id).ToList();
        //    ddlProduto.DataValueField = "Id";
        //    ddlProduto.DataTextField = "PRO_NOME";
        //    ddlProduto.DataBind();

        //}
        public void grupoBoxItem()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();
            List<ModProduto> lstModProduto = negNota.GbNotaItem();
            lstModProduto.Add(new ModProduto { Id = 0, Pro_Nome = "Selecione..." });
            ddlItemProduto.DataSource = lstModProduto.OrderBy(o => o.Id).ToList();
            ddlItemProduto.DataValueField = "Id";
            ddlItemProduto.DataTextField = "PRO_NOME";
            ddlItemProduto.DataBind();

        }
        //public void grupoBoxFornecedor()
        //{

        //    FornecedorNEG neg = new FornecedorNEG();
        //    List<ModFornecedor> lstModFornecedor = neg.GbFornEndereco();
        //    lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
        //    ddlRazaoSocial.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
        //    ddlRazaoSocial.DataValueField = "Id";
        //    ddlRazaoSocial.DataTextField = "Nome";
        //    ddlRazaoSocial.DataBind();
        //    //NotaFicalNEG negNota = new NotaFicalNEG();
        //    //List<ModFornecedor> lstModFornecedor = negNota.GbFornecedor();
        //    //lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
        //    //ddlRazaoSocial.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();   
        //    //ddlRazaoSocial.DataValueField = "Id";
        //    //ddlRazaoSocial.DataTextField = "RazaoSocial";
        //    //ddlRazaoSocial.DataBind();
        //}


        #endregion
    }
}