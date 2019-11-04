using Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class EmpresaNEG
    {
        EmpresaDao emp = new EmpresaDao();
        EmpresaTelefone telefone = new EmpresaTelefone();


        public List<ModEmpresa> Load()
        {
            return emp.SelecionarTodos();
        }
        public List<ModEmpresaTelefone> LoadTel()
        {
            return telefone.SelecionarTodos();

        }

        #region "Botão"
        public void SalvarEmpresa(ModEmpresa empresa)
        {
           
                emp.Adicionar(empresa);
          
            

        }
        public void AtualizarEmpresa(ModEmpresa empresa)
        {
          
                empresa.Id = Convert.ToInt32(empresa.Id);
                emp.Atualizar(empresa);
            
        }

        public void SalvarTelefoneEmpresa(ModEmpresaTelefone modTE)
        {
            //modTE.Id = Convert.ToInt32((Convert.ToUInt32(modTE.Id).ToString()));
            //if (String.IsNullOrEmpty(Convert.ToUInt32(modTE.Id).ToString()))
            //{
                telefone.Adicionar(modTE);

            //}

            //Atualizar
            //else
            //{
                
            //    telefone.Atualizar(modTE);


            //}
        }

        public void EditarTelefoneEmpresa(ModEmpresaTelefone modTE)
        {
            telefone.Atualizar(modTE);
        }
        public void PesquisaEmpresa(ModEmpresa empresa)
        {
            emp.SelecionarPorCnpj(empresa.Cnpj);
        }
        #endregion

        #region"DataGrid
        public List<ModEmpresaTelefone> CamposTelefoneDataGrid(int idEmp)
        {
            return telefone.SelecionarTodos(idEmp);

        }
        #endregion

        public void DataGridCell(int idFornTel)
        {

            telefone.Deletar(idFornTel);

        }

        public List<TipoTelefone> GrupoBobTipoTelefone()
        {
            TipoTelefoneDao telefone = new TipoTelefoneDao();
            return telefone.SelecionarTodos();

        }

        public ModEmpresaTelefone dvSelecionarPorId(int tel)
        {
            ModEmpresaTelefone modTel = new ModEmpresaTelefone();

            modTel = telefone.SelecionarPorId(tel);
            return modTel;
        }
        public ModEmpresa dvEmpresaSelecionarPorId(int empresa)
        {
            ModEmpresa modEmpresa = new ModEmpresa();
            modEmpresa = emp.SelecionarPorId(empresa);
            return modEmpresa;
        }
    }



}

