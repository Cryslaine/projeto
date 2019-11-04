
using Modelo;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using Negocio;

namespace UI.Forms
{
    public partial class NotaFiscalFRN : Form
    {
        int idItem;
        double valor;

        public NotaFiscalFRN()
        {
            InitializeComponent();
        }


        private void NotaFiscalFRN_Load(object sender, EventArgs e)
        {
            grupoBoxProduto();
            grupoBoxFornecedor();
            grupoBoxNotaFical();
            grupoBoxItem();
            camposDataGrid();
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

        #region "Botão Nota Fiscal"
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ModNotaFiscal modNotaFiscal = new ModNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();
            negNota.PesquisaNota(Convert.ToInt32(modNotaFiscal));

            txtId.Text = Convert.ToInt32(modNotaFiscal.Id).ToString();
            txtNumeroDaNota.Text = modNotaFiscal.Numero;
            cboProduto.Text = Convert.ToInt32(modNotaFiscal.IdProduto).ToString();
            txtValor.Text = modNotaFiscal.Valor.ToString();
            cboRazaoSocial.Text = Convert.ToInt32(modNotaFiscal.RazaoSocial).ToString();




        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModNotaFiscal modNotaFiscal = new ModNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();

            modNotaFiscal.Numero = txtNumeroDaNota.Text;
            modNotaFiscal.IdProduto = Convert.ToInt32(cboProduto.SelectedValue);
            modNotaFiscal.Valor = Convert.ToDouble(Regex.Replace(txtValor.Text, "[^0-9,]+", ""));
            modNotaFiscal.RazaoSocial = Convert.ToInt32(cboRazaoSocial.Text);

            if (!ValidarNota(modNotaFiscal))
            {
                return;
            }

            try
            {
                negNota.AdicionarNota(modNotaFiscal);
                MessageBox.Show("Dados inserido com sucesso!");
                limparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModNotaFiscal modNotaFiscal = new ModNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();

            modNotaFiscal.Numero = txtNumeroDaNota.Text;
            modNotaFiscal.IdProduto = Convert.ToInt32(cboProduto.SelectedValue);
            modNotaFiscal.Valor = Convert.ToDouble(Regex.Replace(txtValor.Text, "[^0-9,]+", ""));
            modNotaFiscal.RazaoSocial = Convert.ToInt32(cboRazaoSocial.Text);

            if (!ValidarNota(modNotaFiscal))
            {
                return;
            }

            negNota.EditarNota(modNotaFiscal);
            MessageBox.Show("Formulario atualizado com sucesso!");

            limparCampos();

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ModNotaFiscal modNotaFiscal = new ModNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();

            modNotaFiscal.Id = Convert.ToInt32(txtId.Text);
            negNota.ExcluirNota(modNotaFiscal);

            MessageBox.Show("Excluido com sucesso!");
            grupoBoxFornecedor();
            grupoBoxProduto();

        }
        #endregion

        #region " Botoes Item da Nota"
        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            ModItemNotaFiscal modItemNotaFiscal = new ModItemNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();
            ModProduto modProduto = new ModProduto();

            modItemNotaFiscal.IdNotaFiscal = Convert.ToInt32(cboIdNotaFiscal.Text);
            modItemNotaFiscal.Quantidade = Convert.ToInt32(cboQuantidade.Text);
            modItemNotaFiscal.IdProduto = Convert.ToInt32(cboItemProduto.SelectedValue);
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
            cboIdNotaFiscal.Enabled = true;

        }
        private void BtnEditarItem_Click_1(object sender, EventArgs e)
        {
            ModItemNotaFiscal modItemNotaFiscal = new ModItemNotaFiscal();
            NotaFicalNEG negNota = new NotaFicalNEG();
            ModProduto modProduto = new ModProduto();

            modItemNotaFiscal.Id = Convert.ToInt32(txtIdItem.Text);
            modItemNotaFiscal.IdNotaFiscal = Convert.ToInt32(txtIdItem.Text);
            modItemNotaFiscal.Valor = Convert.ToDouble(txtValorItem.Text);

            negNota.ValidarValor(modItemNotaFiscal, Convert.ToDouble(Regex.Replace(txtValorItem.Text, "[^0-9,]+", "")));

            modItemNotaFiscal.IdNotaFiscal = Convert.ToInt32(cboIdNotaFiscal.Text);
            modItemNotaFiscal.Quantidade = Convert.ToInt32(cboQuantidade.Text);
            modItemNotaFiscal.IdProduto = Convert.ToInt32(cboItemProduto.SelectedValue);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCamposItens();
            btnSalvarItem.Visible = true;
            btnEditarItem.Visible = false;
            cboIdNotaFiscal.Enabled = true;
        }
        #endregion

        #region "GrupBox"
        public void grupoBoxNotaFical()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();

            List<ModNotaFiscal> lstModNotaFiscal = negNota.GbNotaFiscal();
            lstModNotaFiscal.Add(new ModNotaFiscal { Id = 0, Numero = "Selecione..." });
            cboIdNotaFiscal.DataSource = lstModNotaFiscal.OrderBy(o => o.Id).ToList();
            cboItemProduto.DisplayMember = "Selecione...";
            cboItemProduto.ValueMember = "ID";

        }
        public void grupoBoxProduto()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();

            List<ModProduto> lstModProduto = negNota.GbProduto();
            lstModProduto.Add(new ModProduto { Id = 0, Nome = "Selecione..." });
            cboProduto.DataSource = lstModProduto.OrderBy(o => o.Id).ToList();
            cboProduto.DisplayMember = "Nome";
            cboProduto.ValueMember = "Id";
        }
        public void grupoBoxItem()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();
            List<ModProduto> lstModProduto = negNota.GbNotaItem();
            lstModProduto.Add(new ModProduto { Id = 0, Nome = "Selecione..." });
            cboItemProduto.DataSource = lstModProduto.OrderBy(o => o.Id).ToList();
            cboItemProduto.DisplayMember = "NOME";
            cboItemProduto.ValueMember = "ID";
        }
        public void grupoBoxFornecedor()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();
            List<ModFornecedor> lstModFornecedor = negNota.GbFornecedor();
            lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
            cboRazaoSocial.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();

        }
        #endregion



        private void DvgItemDaNota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarItem.Visible = true;
            btnSalvarItem.Visible = false;
            NotaFicalNEG negNota = new NotaFicalNEG();

            idItem = Convert.ToInt32(
              dgvItemDaNota.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (dgvItemDaNota.Columns[e.ColumnIndex] ==
                        dgvItemDaNota.Columns[0])
            {
                txtIdItem.Text = dgvItemDaNota.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboIdNotaFiscal.Text = dgvItemDaNota.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboItemProduto.Text = dgvItemDaNota.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboQuantidade.Text = dgvItemDaNota.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtValorItem.Text = dgvItemDaNota.Rows[e.RowIndex].Cells[6].Value.ToString();
                valor = Convert.ToInt32(dgvItemDaNota.Rows[e.RowIndex].Cells[6].Value);
            }

            if (dgvItemDaNota.Columns[e.ColumnIndex] ==
                        dgvItemDaNota.Columns[1])
            {
                negNota.DvgItem(idItem);
                MessageBox.Show("Excluido com sucesso!");

            }
            camposDataGrid();
            cboIdNotaFiscal.Enabled = false;

        }
        public void camposDataGrid()
        {
            NotaFicalNEG negNota = new NotaFicalNEG();
            dgvItemDaNota.DataSource = negNota.DataGrid().
                Select(a => new { a.Id, a.IdNotaFiscal, a.IdProduto, a.Quantidade, a.Valor }).ToList();
        }
        #region "Limpar Campos"
        private void limparCampos()
        {
            txtId.Text = string.Empty;
            txtNumeroDaNota.Text = string.Empty;
            cboProduto.Text = string.Empty;
            txtValor.Text = string.Empty;
            cboRazaoSocial.Text = string.Empty;
        }

        private void LimparCamposItens()
        {
            txtIdItem.Text = string.Empty;
            cboIdNotaFiscal.Text = string.Empty;
            cboItemProduto.Text = string.Empty; ;
            cboQuantidade.Text = string.Empty;
            txtValorItem.Text = string.Empty;
 
            
        }
        #endregion
    }
}
