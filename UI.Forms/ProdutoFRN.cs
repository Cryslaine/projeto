
using Modelo;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class ProdutoFRN : Form
    {
        int idForn;
        public ProdutoFRN()
        {
            InitializeComponent();
        }
        private void ProdutoFRN_Load(object sender, EventArgs e)
        {
            CampoProdutoDataGrid();
            grupoBoxFornecedor();
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
        private void CampoProdutoDataGrid()
        {

            ProdutoNEG negProd = new ProdutoNEG();
            dgvProduto.DataSource =
               negProd.CampoDgProd().Select(a => new
               { a.Id, a.IdFornecedor, a.Nome, a.Quantidade, a.Preco, a.Peso, a.Tamanho, a.Cor }).ToList();

        }

        private void DgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnCancelar.Enabled = true;
            btnEditar.Visible = true;
            btnSalvar.Visible = false;

            ProdutoNEG negProd = new ProdutoNEG();

            idForn = Convert.ToInt32(
               dgvProduto.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (dgvProduto.Columns[e.ColumnIndex] ==
                        dgvProduto.Columns[0])
            {
                txtId.Text = dgvProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboFornecedor.Text = dgvProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNome.Text = dgvProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboQuantidade.Text = dgvProduto.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPreco.Text = dgvProduto.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPeso.Text = dgvProduto.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtTamanho.Text = dgvProduto.Rows[e.RowIndex].Cells[8].Value.ToString();
                cboCor.Text = dgvProduto.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
            if (dgvProduto.Columns[e.ColumnIndex] ==
                       dgvProduto.Columns[1])
            {
                negProd.DvgProd(idForn);

                MessageBox.Show("Excluido com sucesso!");

            }
            CampoProdutoDataGrid();



        }
        public void grupoBoxFornecedor()
        {
            ProdutoNEG negProd = new ProdutoNEG();
            List<ModFornecedor> lstModFornecedor = negProd.GbFornecedor();
            lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
            cboFornecedor.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
        }

        #region "Botão"
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoNEG negProd = new ProdutoNEG();
            ModProduto modProduto = new ModProduto();

            modProduto.Nome = txtPesquisa.Text;

            List<ModProduto> listaProduto = negProd.PesquisarProduto(modProduto);

            dgvProduto.DataSource = listaProduto.Select(a => new
            { a.Id, a.IdFornecedor, a.Nome, a.Quantidade, a.Preco, a.Peso, a.Tamanho, a.Cor }).ToList();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;

            ModProduto modProduto = new ModProduto();
            ProdutoNEG negProd = new ProdutoNEG();


            modProduto.IdFornecedor = Convert.ToInt32(cboFornecedor.SelectedValue);
            modProduto.Nome = txtNome.Text;
            modProduto.Preco = Convert.ToDouble(txtPreco.Text);
            modProduto.Preco = (modProduto.CalcularImposto(Convert.ToDouble(txtPreco.Text)) + (Convert.ToDouble(txtPreco.Text)));
            modProduto.Tamanho = Convert.ToInt32(txtTamanho.Text);
            modProduto.Peso = Convert.ToDecimal(txtPeso.Text);
            modProduto.Cor = cboCor.Text;
            modProduto.Quantidade = Convert.ToInt32(cboQuantidade.Text);

            if (!ValidarProduto(modProduto))
            {
                return;
            }
            negProd.SalvarProduto(modProduto);

            LimparCampos();
            btnEditar.Visible = true;

            CampoProdutoDataGrid();


        }
        #endregion

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ModProduto modProduto = new ModProduto();
            ProdutoNEG negProd = new ProdutoNEG();

            modProduto.Id = Convert.ToInt32(txtId.Text);
            modProduto.Preco = Convert.ToDouble(txtPreco.Text);

            negProd.CalculoProduto(modProduto, Convert.ToDouble(txtPreco.Text));
                

            modProduto.IdFornecedor = Convert.ToInt32(cboFornecedor.SelectedValue);
            modProduto.Nome = txtNome.Text;
            modProduto.Tamanho = Convert.ToInt32(txtTamanho.Text);
            modProduto.Peso = Convert.ToDecimal(txtPeso.Text);
            modProduto.Cor = cboCor.Text;
            modProduto.Quantidade = Convert.ToInt32(cboQuantidade.Text);
            modProduto.Id = Convert.ToInt32(txtId.Text);
            //  modProduto = new ModProduto(Convert.ToDouble(txtPreco.Text));
            //modProduto.Preco = (modProduto.CalcularImposto(Convert.ToDouble(txtPreco.Text)));




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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnSalvar.Visible = true;
        }
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtTamanho.Text = string.Empty;
            txtPeso.Text = string.Empty;
            cboCor.Text = string.Empty;
            cboQuantidade.Text = string.Empty;
            cboFornecedor.Text = string.Empty;
        }
    }
}

