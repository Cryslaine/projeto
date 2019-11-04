using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class NotaFicalNEG
    {
        NotaFiscalDao notaF = new NotaFiscalDao();
        ItemNotaFiscalDao notaIF = new ItemNotaFiscalDao();
        #region "Botão da Nota"
        public ModNotaFiscal PesquisaNota(int numero)
        {
            return notaF.SelecionarPorNumeroDaNota(numero);
        }
        private bool ValidaNota(int numero)
        {
            var notaExistente = notaF.SelecionarPorNumeroDaNota(numero);
            if (notaExistente.Numero != null && notaExistente.Numero == Convert.ToInt32(numero).ToString())
            {

                return false;
            }

            return true;

        }
        public void AdicionarNota(ModNotaFiscal modNotaFiscal)
        {
            if (!ValidaNota(Convert.ToInt32(modNotaFiscal.Numero)))
            {
                throw new Exception("Nota já cadastrado");
            }

            notaF.Adicionar(modNotaFiscal);

        }
        public void EditarNota(ModNotaFiscal modNotaFiscal)
        {
            modNotaFiscal.Id = Convert.ToInt32(modNotaFiscal.Id);
            notaF.Atualizar(modNotaFiscal);
        }
        public void ExcluirNota(ModNotaFiscal modNotaFiscal)
        {
            modNotaFiscal.Id = Convert.ToInt32(modNotaFiscal.Id);
            notaF.Deletar(modNotaFiscal.Id);
        }
        #endregion

        #region " Botoes Item da Nota"

        public void SalvarItem(ModItemNotaFiscal modItemNotaFiscal)
        {

            notaIF.Adicionar(modItemNotaFiscal);

        }
        public void ValidarValor(ModItemNotaFiscal modItemNotaFiscal, double valorItem)
        {

            ModProduto modProduto = new ModProduto();
            var valorCalculo = notaIF.SelecionarPorId(Convert.ToInt32(modItemNotaFiscal.Id));
            if (valorCalculo.Valor != (Convert.ToDouble(Regex.Replace(modItemNotaFiscal.Valor.ToString(), "[^0-9,]+", ""))))
            {
                modProduto = new ModProduto(Convert.ToDouble(Regex.Replace(modItemNotaFiscal.Valor.ToString(), "[^0-9,]+", "")));
                modItemNotaFiscal.Valor = modProduto.PrecoVenda;
            }
            else
            {
                modItemNotaFiscal.Valor = (Convert.ToDouble(Regex.Replace(modItemNotaFiscal.Valor.ToString(), "[^0-9,]+", "")));
            }




        }
        public void AtualizarItemNota(ModItemNotaFiscal modItemNotaFiscal)
        {

            modItemNotaFiscal.Id = Convert.ToInt32(modItemNotaFiscal.Id);
            notaIF.Atualizar(modItemNotaFiscal);
        }

        #endregion
        public void DvgItem(int idItem)
        {
            notaIF.Deletar(idItem);
        }

        public List<ModItemNotaFiscal> DataGrid()
        {
            return notaIF.SelecionarTodos();


        }
        public List<ModProduto> GbNotaItem()
        {
            ProdutoDao forn = new ProdutoDao();
            return forn.SelecionarTodos();
        }
        public List<ModProduto> GbProduto()
        {
            ProdutoDao forn = new ProdutoDao();
            return forn.SelecionarTodos();
        }
        public List<ModNotaFiscal> GbNotaFiscal()
        {
            return notaF.SelecionarTodos();
        }
        public List<ModFornecedor> GbFornecedor()
        {
            FornecedorDao forn = new FornecedorDao();
            return forn.SelecionarTodos();
        }

        public ModItemNotaFiscal dvSelectId(int idItemNota)
        {
            ModItemNotaFiscal modIdNota = new ModItemNotaFiscal();

            modIdNota = notaIF.SelecionarPorId(idItemNota);
            return modIdNota;
        }
    }
}
