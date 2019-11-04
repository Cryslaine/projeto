

using Modelo;
using Negocio;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class EmpresaFRN : Form
    {
        #region "Variavel Global"
        int idFornTel;
        #endregion
        public EmpresaFRN()
        {
            InitializeComponent();
        }


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
        private void EmpresaFRN1_Load(object sender, EventArgs e)
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
            btnEditarTelefone.Visible = false;

        }
    
        #region "Botao"
        private void btnSalvar_Click(object sender, EventArgs e)
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


                //negEmp.SalvarEAtualizarEmpresa(modEmpresa);


            //Campos ativos
            habilitardesabilitar(false);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            preenchimentoCampos(null);

            habilitardesabilitar(true);
        }

        private void btnSalvarTelefone_Click(object sender, EventArgs e)
        {

            ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            EmpresaNEG negEmp = new EmpresaNEG();

            modTE.Tipo = new TipoTelefone { Id = Convert.ToInt32(cboTipo.SelectedValue) };
            modTE.IdEmpresa = Convert.ToInt32(txtidEmpresa.Text);
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

        private void BtnEditarTelefone_Click(object sender, EventArgs e)
        {
            ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            EmpresaNEG negEmp = new EmpresaNEG();

            modTE.Id = Convert.ToInt32(txtId.Text);
            modTE.Tipo = new TipoTelefone { Id = Convert.ToInt32(cboTipo.SelectedValue) };
            modTE.IdEmpresa = Convert.ToInt32(txtidEmpresa.Text);
            modTE.Telefone = txtNumeroTelefone.Text;

            if (!ValidarEmpresa(modTE))
            {
                return;
            }
            negEmp.EditarTelefoneEmpresa(modTE);
            MessageBox.Show("Formulario atualizado com sucesso!");
            camposDataGrid();
            limparCamposTelefone();
            btnSalvarTelefone.Visible = false;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ModEmpresa modEmpresa = new ModEmpresa();
            EmpresaNEG negEmp = new EmpresaNEG();

            negEmp.PesquisaEmpresa(modEmpresa);

            preenchimentoCampos(modEmpresa);
            habilitardesabilitar(false);

            MessageBox.Show("Pesquisa efetuada com sucesso!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            ModEmpresa modEmpresa = new ModEmpresa();

            habilitardesabilitar(true);

        }
        #endregion

        #region"Habilitar, desabilitar e preencher campos
        private void habilitardesabilitar(bool tipo)
        {
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
            btnSalvar.Enabled = tipo;
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
            txtidEmpresa.Text = Convert.ToString(modEmpresa.Id);

        }
        #endregion

        public void camposDataGrid()
        {
            
            EmpresaNEG negEmp = new EmpresaNEG();
            dgvTelefone.DataSource =
                negEmp.CamposTelefoneDataGrid(Convert.ToInt32(txtidEmpresa.Text))
                .Select(a => new { a.Id, a.Telefone, a.Tipo.Descricao }).ToList();



        }
        public void grupBoxTipos()
        {

            //Tras os itens cadastrados no banco e acrescrenta um novo item a lista ...

            EmpresaNEG negEmp = new EmpresaNEG();
            List<TipoTelefone> lstTipoTelefone = negEmp.GrupoBobTipoTelefone();
            lstTipoTelefone.Add(new TipoTelefone { Id = 0, Descricao = "Selecione..." });
            cboTipo.DataSource = lstTipoTelefone.OrderBy(o => o.Id).ToList();


        }

        private void DgvTelefone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSalvarTelefone.Visible = false;
            btnEditarTelefone.Visible = true;
            //ModEmpresaTelefone modTE = new ModEmpresaTelefone();
            EmpresaNEG negEmp = new EmpresaNEG();

            idFornTel = Convert.ToInt32(
               dgvTelefone.Rows[e.RowIndex].Cells["Id"].Value.ToString());
      
        

            if (dgvTelefone.Columns[e.ColumnIndex] ==
               dgvTelefone.Columns[0])
            {
                
                txtId.Text = dgvTelefone.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtNumeroTelefone.Text = dgvTelefone.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                cboTipo.Text = dgvTelefone.Rows[e.RowIndex].Cells["TipoTelefone"].Value.ToString();
              


            }
            if (dgvTelefone.Columns[e.ColumnIndex] ==
              dgvTelefone.Columns[1])
            {
                negEmp.DataGridCell(idFornTel);
            
                MessageBox.Show("Excluido com sucesso!");
               
            }
            camposDataGrid();


        }

        private void limparCamposTelefone()
        {
            cboTipo.Text = string.Empty;
            txtNumeroTelefone.Text = string.Empty;
            txtId.Text = string.Empty;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limparCamposTelefone();
            btnSalvarTelefone.Visible = true;
            btnEditarTelefone.Visible = false;

        }

        
    }
    
}