using Data;
using Modelo;
using System;
using System.Collections.Generic;

namespace Teste
{
    //public class Program

    //{
    //static void Main(string[] args)
    //{



    //    ModFornecedor entidade = new ModFornecedor();
    //    entidade.Nome = "Paulo salao";
    //    entidade.RazaoSocial = "PauloSalao industria LTDA";
    //    entidade.Cnpj = "77.567.254/5847-21";
    //    entidade.Telefone = "(11)89906-0823";
    //    entidade.Endereco = " hjkdfhdjkfhdjk";

    // Inserir (Insert)
    //FornecedorDao fornecedorDao = new FornecedorDao();
    //fornecedorDao.Adicionar(entidade);

    //FornecedorDao fornecedorDao = new FornecedorDao();
    // fornecedorDao.Atualizar(entidade);






    ///DELETAR POR ID
    //        FornecedorDao fornecedorDao = new FornecedorDao();
    //fornecedorDao.Deletar(2);
    //ModFornecedor lst = fornecedorDao.SelecionarPorId(2);


    //SELECIONAR POR ID
    //FornecedorDao fornecedorDao = new FornecedorDao();

    //ModFornecedor selecFor = fornecedorDao.SelecionarPorId(8);
    //Console.WriteLine(selecFor.Id);
    //Console.WriteLine(selecFor.Nome);
    //Console.WriteLine(selecFor.RazaoSocial);
    //Console.WriteLine(selecFor.Cnpj);
    //Console.WriteLine(selecFor.Telefone);
    //Console.WriteLine(selecFor.Endereco);



    //            //SELECT POR LISTA
    //            FornecedorDao fornecedorDao = new FornecedorDao();
    //            List<ModFornecedor> sfornecedor = fornecedorDao.SelecionarTodos();
    //            // ModFornecedor item = fornecedorDao.SelecionarPorId(1);

    //            for (int i = 0; i < sfornecedor.Count; i++)
    //            {
    //                Console.WriteLine(sfornecedor[i].Id);
    //                Console.WriteLine(sfornecedor[i].Nome);
    //                Console.WriteLine(sfornecedor[i].RazaoSocial);
    //                Console.WriteLine(sfornecedor[i].Cnpj);
    //                Console.WriteLine(sfornecedor[i].Telefone);
    //                Console.WriteLine(sfornecedor[i].Endereco);

    //            }
    //        }


    //    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //public class Program

    //{
    //    static void Main(string[] args)
    //    {



    //        Produto entidade = new Produto();
    //        entidade.Id = 1;
    //        entidade.Nome = "Vestido";
    //        entidade.Preco = 60;
    //        entidade.Tamanho = 5;
    //        entidade.Peso = 3;
    //        entidade.Cor = " Rosa";
    //        entidade.Quantidade = 70;


    // //Inserir(Insert)
    //ProdutoDao produtoDao = new ProdutoDao();
    //produtoDao.Adicionar(entidade);

    ////Atualizar(Update)
    //ProdutoDao produtoDao = new ProdutoDao();
    //produtoDao.Atualizar(entidade);


    // DELETAR POR ID
    //ProdutoDao produtoDao = new ProdutoDao();
    //produtoDao.Deletar(3);
    //Produto lst = produtoDao.SelecionarPorId(3);


    //SELECIONAR POR ID
    //ProdutoDao produtoDao = new ProdutoDao();
    //Produto selecPro = produtoDao.SelecionarPorId(1);

    //Console.WriteLine(selecPro.Id);
    //Console.WriteLine(selecPro.Nome);
    //Console.WriteLine(selecPro.Preco);
    //Console.WriteLine(selecPro.Tamanho);
    //Console.WriteLine(selecPro.Peso);
    //Console.WriteLine(selecPro.Cor);
    //Console.WriteLine(selecPro.Quantidade);





    //            //SELECT POR LISTA
    //ProdutoDao produtoDao = new ProdutoDao();
    //List<Produto> sproduto = produtoDao.SelecionarTodos();
    //// ModFornecedor item = fornecedorDao.SelecionarPorId(1);

    //for (int i = 0; i < sproduto.Count; i++)
    //{
    //    Console.WriteLine(sproduto[i].Id);
    //    Console.WriteLine(sproduto[i].Nome);
    //    Console.WriteLine(sproduto[i].Preco);
    //    Console.WriteLine(sproduto[i].Tamanho);
    //    Console.WriteLine(sproduto[i].Peso);
    //    Console.WriteLine(sproduto[i].Cor);
    //    Console.WriteLine(sproduto[i].Quantidade);

    //}

//////////////////////////////////////////////////////////////////////////////////////////////////
    public class Program

    {
        static void Main(string[] args)
        {



            //ModEnderecoFornecedor entidade = new ModEnderecoFornecedor();
            //entidade.Endereco = "Rua mirante";
            //entidade.Bairro = "Mirante da Mata";
            //entidade.Numero = "45";
            //entidade.Cidade = "Cotia";
            //entidade.UF = "SP";
            //entidade.CEP = "06720162";
            //entidade.Complemento = "";



            //// //Inserir(Insert)
            //EnderecoFornecedor end = new EnderecoFornecedor();
            //end.Adicionar(entidade);

            ////Atualizar(Update)
            //EnderecoFornecedor end = new EnderecoFornecedor();
            //end.Atualizar(entidade);


            // DELETAR POR ID
            //EnderecoFornecedor end = new EnderecoFornecedor();
            //end.Deletar(3);
            //ModEnderecoFornecedor lst = end.SelecionarPorId(3);


            //SELECIONAR POR ID
            //EnderecoFornecedor produtoDao = new EnderecoFornecedor();
            //ModEnderecoFornecedor selecForEnd = produtoDao.SelecionarPorId(1);

            //Console.WriteLine(selecForEnd.Id);
            //Console.WriteLine(selecForEnd.Endereco);
            //Console.WriteLine(selecForEnd.Bairro);
            //Console.WriteLine(selecForEnd.Numero);
            //Console.WriteLine(selecForEnd.Cidade);
            //Console.WriteLine(selecForEnd.UF);
            //Console.WriteLine(selecForEnd.CEP);
            //Console.WriteLine(selecForEnd.Complemento);





            //            //SELECT POR LISTA
            //ProdutoDao produtoDao = new ProdutoDao();
            //List<Produto> sproduto = produtoDao.SelecionarTodos();
            //// ModFornecedor item = fornecedorDao.SelecionarPorId(1);

            //for (int i = 0; i < sproduto.Count; i++)
            //{
            //    Console.WriteLine(sproduto[i].Id);
            //    Console.WriteLine(sproduto[i].Nome);
            //    Console.WriteLine(sproduto[i].Preco);
            //    Console.WriteLine(sproduto[i].Tamanho);
            //    Console.WriteLine(sproduto[i].Peso);
            //    Console.WriteLine(sproduto[i].Cor);
            //    Console.WriteLine(sproduto[i].Quantidade);

            //}



            ModEmpresaTelefone entidade = new ModEmpresaTelefone();
            entidade.Tipo = "Fixo";
            entidade.DD = "11";
            entidade.Numero = "5555-5555";


            // //Inserir(Insert)
            EmpresaTelefone end = new EmpresaTelefone();
            end.Adicionar(entidade);

            //EnderecoFornecedor end = new EnderecoFornecedor();
            //end.Atualizar(entidade);

        }

    }
}
