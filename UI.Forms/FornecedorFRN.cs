
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Negocio;


namespace UI.Forms
{
    public partial class FornecedorFRN : Form
    {
        #region "Variavel Global"
        int idForn;
        ModFornecedorTelefone verTele = new ModFornecedorTelefone();
        ModEnderecoFornecedor verEndereco = new ModEnderecoFornecedor();


        #endregion


        public FornecedorFRN()
        {
            InitializeComponent();
        }

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

        private void FornecedorFRN_Load(object sender, EventArgs e)
        {

            grupoBoxFornecedor();
            grupoBoxFornecedorEndereco();
            grupBoxTipo();
            camposDataGrid();
            CamposEnderecoDataGrid();
            btnEditarTelefone.Visible = false;
            btnEditarEndereço.Visible = false;
        }


        #region "Botão"
        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();


            modF.RazaoSocial = txtRazaoSocial.Text;
            modF.Nome = txtNome.Text;
            modF.Cnpj = (Regex.Replace(txtCnpj.Text, @"[^0-9]+?", ""));

            if (!ValidarFornecedor(modF))
            {
                return;
            }


            try
            {
                neg.AdicionarFor(modF);
                MessageBox.Show("Dados salvos com sucesso!");
                grupoBoxFornecedor();
                grupoBoxFornecedorEndereco();
                limparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modF.Id = Convert.ToInt32(txtId.Text);
            neg.ExcluirFor(modF);

            MessageBox.Show("Dados Excluido com sucesso!");
            grupoBoxFornecedor();
            grupoBoxFornecedorEndereco();
            limparCampos();


        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();
            modF = neg.PesquisarFornecedor(Regex.Replace(txtCnpjPesquisa.Text, "[^0-9a-zA-Z]+", ""));

            txtId.Text = Convert.ToInt32(modF.Id).ToString();
            txtRazaoSocial.Text = modF.RazaoSocial;
            txtNome.Text = modF.Nome;
            txtCnpj.Text = modF.Cnpj;
            MessageBox.Show("Pesquisa realizada com sucesso!");

        }
        private void btnSalvarEndereco_Click_1(object sender, EventArgs e)
        {

            ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modEF.IdFornecedor = Convert.ToInt32(cboFornecedorEmpresa.SelectedValue);
            modEF.Endereco = txtEndereco.Text;
            modEF.Bairro = txtBairro.Text;
            modEF.Numero = txtEnderecoN.Text;
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
        private void BtnEditarEndereço_Click(object sender, EventArgs e)
        {
            ModEnderecoFornecedor modEF = new ModEnderecoFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modEF.Id = Convert.ToInt32(txtIdEnd.Text);
            modEF.IdFornecedor = Convert.ToInt32(cboFornecedorEmpresa.SelectedValue);
            modEF.Endereco = txtEndereco.Text;
            modEF.Bairro = txtBairro.Text;
            modEF.Numero = txtEnderecoN.Text;
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
            btnEditarEndereço.Visible = false;
        }

        private void btnCancelarEndereco_Click(object sender, EventArgs e)
        {
            limparCamposEndereco();
            btnSalvarEndereco.Visible = true;
            btnEditarEndereço.Visible = false;

        }
        private void btnSalvarTelefone_Click_1(object sender, EventArgs e)
        {
            ModFornecedorTelefone modTF = new ModFornecedorTelefone();
            FornecedorNEG neg = new FornecedorNEG();

            modTF.Tipo = new TipoTelefone { Id = Convert.ToInt32(cboTipo.SelectedValue) };
            modTF.IdFornecedor = Convert.ToInt32(cboFornecedor.SelectedValue);
            modTF.Telefone = txtNumeroTelefone.Text;


            if (!ValidarFornecedor(modTF))
            {
                return;
            }

            neg.AdicionarTel(modTF);
            MessageBox.Show("Formulario salvos com sucesso!");

            camposDataGrid();
            limparCamposTelefone();
        }

        private void BtnEditarTelefone_Click(object sender, EventArgs e)
        {
            ModFornecedorTelefone modTF = new ModFornecedorTelefone();
            FornecedorNEG neg = new FornecedorNEG();

            modTF.Id = Convert.ToInt32(txtIdTelFor.Text);
            modTF.Tipo = new TipoTelefone { Id = Convert.ToInt32(cboTipo.SelectedValue) };
            modTF.IdFornecedor = Convert.ToInt32(cboFornecedor.SelectedValue);
            modTF.Telefone = txtNumeroTelefone.Text;


            if (!ValidarFornecedor(modTF))
            {
                return;
            }

            neg.AtualizarTel(modTF);
            MessageBox.Show("Formulario atualizado com sucesso!");
            camposDataGrid();
            limparCamposTelefone();
        }

        private void BtnCancelarTelefone_Click(object sender, EventArgs e)
        {
            limparCamposTelefone();
            btnSalvarTelefone.Visible = true;
            btnEditarTelefone.Visible = false;
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            ModFornecedor modF = new ModFornecedor();
            FornecedorNEG neg = new FornecedorNEG();

            modF.Id = Convert.ToInt32(txtId.Text);
            modF.RazaoSocial = txtRazaoSocial.Text;
            modF.Nome = txtNome.Text;
            modF.Cnpj = Regex.Replace(txtCnpj.Text, "[^0-9a-zA-Z]+", "");


            if (!ValidarFornecedor(modF))
            {
                return;
            }

            neg.AtualizarFornecedor(modF);
            MessageBox.Show("Formulario atualizado com sucesso!");
            limparCampos();


        }

        #endregion


        #region "Lista de GrupBox"
        public void grupBoxTipo()
        {

            FornecedorNEG neg = new FornecedorNEG();
            List<TipoTelefone> lstTipoTelefone = neg.GbTipo();
            lstTipoTelefone.Add(new TipoTelefone { Id = 0, Descricao = "Selecione..." });
            cboTipo.DataSource = lstTipoTelefone.OrderBy(o => o.Id).ToList();
        }
        public void grupoBoxFornecedor()
        {
            FornecedorNEG neg = new FornecedorNEG();
            List<ModFornecedor> lstModFornecedor = neg.GbFornecedor();
            lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
            cboFornecedor.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();
        }
        public void grupoBoxFornecedorEndereco()
        {
            grupoBoxFornecedor();
            FornecedorNEG neg = new FornecedorNEG();
            List<ModFornecedor> lstModFornecedor = neg.GbFornEndereco();
            lstModFornecedor.Add(new ModFornecedor { Id = 0, Nome = "Selecione..." });
            cboFornecedorEmpresa.DataSource = lstModFornecedor.OrderBy(o => o.Id).ToList();

        }
        #endregion

        #region " Posição e informações do DataGrid"
        public void camposDataGrid()
        {

            FornecedorNEG neg = new FornecedorNEG();
            dgvTelefoneFornecedor.DataSource =
               neg.TelefoneDataGrid().
               Select(a => new { a.Id, a.IdFornecedor, a.Telefone, a.Tipo.Descricao }).ToList();

        }
        public void CamposEnderecoDataGrid()
        {
            FornecedorNEG neg = new FornecedorNEG();
            dgvEnderecoFornecedor.DataSource =
                 neg.EnderecoDataGrid().Select(a => new
                 { a.Id, a.IdFornecedor, a.Endereco, a.Bairro, a.Numero, a.Cidade, a.UF, a.CEP, a.Complemento }).ToList();
        }
        #endregion


        #region " Posição de retorno para edição de campos"
        private void DgvEnderecoFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarEndereço.Visible = true;
            btnSalvarEndereco.Visible = false;
            FornecedorNEG neg = new FornecedorNEG();

            idForn = Convert.ToInt32(
             dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (dgvEnderecoFornecedor.Columns[e.ColumnIndex] ==
                        dgvEnderecoFornecedor.Columns[0])
            {
                txtIdEnd.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboFornecedorEmpresa.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEndereco.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBairro.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEnderecoN.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCidade.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtUf.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtCep.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtComplemento.Text = dgvEnderecoFornecedor.Rows[e.RowIndex].Cells[10].Value.ToString();


            }

            if (dgvEnderecoFornecedor.Columns[e.ColumnIndex] ==
                        dgvEnderecoFornecedor.Columns[1])
            {
                neg.DvgEndForne(idForn);

                MessageBox.Show("Excluido com sucesso!");

            }

            CamposEnderecoDataGrid();

        }

        private void DgvTelefoneFornecedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnSalvarTelefone.Visible = false;
            btnEditarTelefone.Visible = true;

            FornecedorNEG neg = new FornecedorNEG();

            idForn = Convert.ToInt32(
              dgvTelefoneFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (dgvTelefoneFornecedor.Columns[e.ColumnIndex] ==
                        dgvTelefoneFornecedor.Columns[0])
            {

                txtIdTelFor.Text = dgvTelefoneFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboTipo.Text = dgvTelefoneFornecedor.Rows[e.RowIndex].Cells[5].Value.ToString();
                cboFornecedor.Text = dgvTelefoneFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNumeroTelefone.Text = dgvTelefoneFornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

            if (dgvTelefoneFornecedor.Columns[e.ColumnIndex] ==
                        dgvTelefoneFornecedor.Columns[1])
            {
                neg.DvgTelForneDelet(idForn);

                MessageBox.Show("Excluido com sucesso!");

            }
            camposDataGrid();


        }
        #endregion

        //Limpar campos  
        private void limparCampos()
        {
            txtRazaoSocial.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnpj.Text = string.Empty;

        }
        private void limparCamposEndereco()
        {
            cboFornecedor.SelectedText = string.Empty;
            cboFornecedorEmpresa.SelectedText = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEnderecoN.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtComplemento.Text = string.Empty;

        }

        public void limparCamposTelefone()
        {
            txtIdTelFor.Text = string.Empty;
            cboTipo.Text = string.Empty;
            txtNumeroTelefone.Text = string.Empty;
            cboFornecedor.Text = string.Empty;
        }


    }
}
