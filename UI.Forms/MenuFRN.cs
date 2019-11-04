using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class MenuFRN : Form
    {
        //private int childFormNumber = 0;

        public MenuFRN()
        {
            InitializeComponent();
        }
        //EmpresaFRN
        private void ShowNewForm(object sender, EventArgs e)
        {
            EmpresaFRN dados = new EmpresaFRN();
            dados.MdiParent = this;
            dados.Show();

        }
        //Empresa_TelefoneFRN
        
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MenuFRN_Load(object sender, EventArgs e)
        {

        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //FornecedorFRN
        private void DadosCadastraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedorFRN dados = new FornecedorFRN();
            dados.MdiParent = this;
            dados.Show();
        }
        //Fornecedor_Telefone
        //private void TelefonesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Fornecedor_TelefoneFRN dados = new Fornecedor_TelefoneFRN();
        //    dados.MdiParent = this;
        //    dados.Show();
        //}
        //Forncedor_EnderecoFRN
        //private void EndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Fornecedor_EnderecoFRN dados = new Fornecedor_EnderecoFRN();
        //    dados.MdiParent = this;
        //    dados.Show();
        //}
        ////ProdutosFRN
        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoFRN dados = new ProdutoFRN();
            dados.MdiParent = this;
            dados.Show();

        }

        private void DadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotaFiscalFRN dados = new NotaFiscalFRN();
            dados.MdiParent = this;
            dados.Show();
        }
    }
}
