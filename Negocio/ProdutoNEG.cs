using Data;
using Modelo;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ProdutoNEG
    {
        ProdutoDao produtoDao = new ProdutoDao();
        public List<ModProduto> CampoDgProd()
        {
            return produtoDao.SelecionarTodos();

        }

        public void DvgProd(int idForn)
        {
            produtoDao.Deletar(idForn);
        }
        public List<ModFornecedor> GbFornecedor()
        {
            FornecedorDao forn = new FornecedorDao();
            return forn.SelecionarTodos();
        }

        public void CalculoProduto(ModProduto modProduto, double valor)
        {


            var valorItem = produtoDao.SelecionarPorId(Convert.ToInt32(modProduto.Id));
            if (valorItem.Preco != (Convert.ToDouble(modProduto.Preco.ToString())))
            {
                modProduto.Preco = (modProduto.CalcularImposto(Convert.ToDouble(modProduto.Preco)) + (Convert.ToDouble(modProduto.Preco)));
                modProduto.Preco = modProduto.Preco;
            }
            else
            {
                modProduto.Preco = Convert.ToDouble(modProduto.Preco);
            }


        }
        public void EditarProduto(ModProduto modProduto)
        {
            modProduto.Id = Convert.ToInt32(modProduto.Id);
            produtoDao.Atualizar(modProduto);
        }
        public void SalvarProduto(ModProduto modProduto)
        {

            produtoDao.Adicionar(modProduto);

        }
        public List<ModProduto> PesquisarProduto(ModProduto modProduto)
        {

            return produtoDao.SelecionarPorNome(modProduto.Pro_Nome);


        }

        //public ModProduto PesquisarProduto(string nome)
        //{

        //    return produtoDao.SelecionarPorNome(nome);
        //}

        public ModProduto dvSelect(int prod)
        {
            ModProduto produto = new ModProduto();
            produto = produtoDao.SelecionarPorId(prod);
            return produto;
        }

    }
}
