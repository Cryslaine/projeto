using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class FornecedorNEG
    {

        FornecedorDao forn = new FornecedorDao();
        FornecedorTelefone fornT = new FornecedorTelefone();
        EnderecoFornecedor endereco = new EnderecoFornecedor();
        EnderecoFornecedor fornE = new EnderecoFornecedor();
        
        public FornecedorNEG()
        {


        }

        private bool ValidaCnpjFornecedor(string Cnpj)
        {
            var cnpjExistente = forn.SelecionarPorCnpj(Regex.Replace(Cnpj, @"[^0-9]+?", ""));
            if (cnpjExistente.Cnpj != null && cnpjExistente.Cnpj == Regex.Replace(Cnpj, @"[^0-9]+?", ""))
            {
               
                return false;
            }

            return true;


        }
        #region "Botão"
        public ModFornecedor  PesquisarFornecedor(string cnpj)
        {
           
           return forn.SelecionarPorCnpj(cnpj);

        }
        public void AdicionarFor(ModFornecedor mod)
        {
            if(!ValidaCnpjFornecedor(mod.Cnpj))
            {
                throw new Exception("Cnpj já cadastrado");
            }

            forn.Adicionar(mod);
        }
       
        public void ExcluirFor(ModFornecedor mod )
        {
            mod.Id = Convert.ToInt32(mod.Id);

            forn.Deletar(mod.Id);
           
        }

        public void AtualizarFornecedor(ModFornecedor mod)
        {
            mod.Id = Convert.ToInt32(mod.Id);
      
            forn.Atualizar(mod);
        }

        public void AdicionarTel (ModFornecedorTelefone telFor)
        {

                fornT.Adicionar(telFor);
        }
        public void AtualizarTel(ModFornecedorTelefone telFor)
        {

                fornT.Atualizar(telFor);

        }

        public void AdicionarEndereco( ModEnderecoFornecedor endFor)
        {
  
                fornE.Adicionar(endFor);

        }
        public void AtualizarEndereco(ModEnderecoFornecedor endFor)
        {
          
                fornE.Atualizar(endFor);
            
        }

        #endregion

        public List<ModEnderecoFornecedor> EnderecoDataGrid()
        {
            return endereco.SelecionarTodos(0);
        }
        public List<ModFornecedorTelefone> TelefoneDataGrid()
        {
             return fornT.SelecionarTodos(0);
                
        }
        public List<ModFornecedor> GbFornEndereco()
        {
            return forn.SelecionarTodos();
        }
        public List<ModFornecedor> GbFornecedor()
        {
            return forn.SelecionarTodos();
        }

        public List<TipoTelefone> GbTipo()
        {
            TipoTelefoneDao telefone = new TipoTelefoneDao();
            return telefone.SelecionarTodos();
        }
        public void DvgTelForneDelet(int idForn)
        {
            try
            {
                fornT.Deletar(idForn);
            }
            catch(Exception e)
            {
                
            }
        }
        public void DvgEndForne(int idForn)
        {

            endereco.Deletar(idForn);
        }
        public ModFornecedorTelefone dvSelect(int idForn)
        {
            ModFornecedorTelefone tel = new ModFornecedorTelefone();

            tel = fornT.SelecionarPorId(idForn);
            return tel ;
        }
        public void Dvatualizar(ModFornecedorTelefone telefone)
        {
            telefone.Id = Convert.ToInt32(telefone.Id);
            fornT.Atualizar(telefone);
        }

        public ModEnderecoFornecedor dvSelectEnd(int endForn)
        {
            ModEnderecoFornecedor end = new ModEnderecoFornecedor();
            end = endereco.SelecionarPorId(endForn);
            return end;
        }
    }
}
