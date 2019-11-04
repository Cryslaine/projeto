using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
    public class FornecedorTelefone : ICRUD<ModFornecedorTelefone>
    {
        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        private string ComandoSQL = string.Empty;

        public void Adicionar(ModFornecedorTelefone entidade)
        {
            
            ComandoSQL = @"INSERT INTO TAB_FORNECEDOR_TELEFONE(TIPO,ID_FORNECEDOR, TELEFONE) VALUES(@TIPO,@ID_FORNECEDOR, @TELEFONE)";
            TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter  { ParameterName = "@TIPO", Value = entidade.Tipo.Id });
            lst.Add(new SqlParameter { ParameterName = "@ID_FORNECEDOR", Value = entidade.IdFornecedor });
            lst.Add(new SqlParameter { ParameterName = "@TELEFONE", Value = entidade.Telefone });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);

        }

        public void Atualizar(ModFornecedorTelefone entidade)
        {
            ComandoSQL = @"UPDATE TAB_FORNECEDOR_TELEFONE  SET ID_FORNECEDOR = @ID_FORNECEDOR , TIPO = @TIPO, TELEFONE = @TELEFONE  
                            WHERE Id = @Id";

            TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id});
            lst.Add(new SqlParameter { ParameterName = "@ID_FORNECEDOR", Value = entidade.IdFornecedor });
            lst.Add(new SqlParameter { ParameterName = "@TIPO", Value = entidade.Tipo.Id });
            lst.Add(new SqlParameter { ParameterName = "@TELEFONE", Value = entidade.Telefone });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }



        public void Deletar(int id)
        {
            ComandoSQL = @"DELETE FROM TAB_FORNECEDOR_TELEFONE WHERE @ID = Id";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public ModFornecedorTelefone SelecionarPorId(int id)
        {
            ComandoSQL = "SELECT ID,TIPO,ID_FORNECEDOR, TELEFONE FROM TAB_FORNECEDOR_TELEFONE WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            ModFornecedorTelefone telefoneFornecedor = new ModFornecedorTelefone();

            TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
         
            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    telefoneFornecedor.Id = Convert.ToInt32(dr["ID"]);
                    telefoneFornecedor.IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"]);
                    telefoneFornecedor.Tipo = tipoTeledone.SelecionarPorId(Convert.ToInt32(dr["TIPO"]));
                    telefoneFornecedor.Telefone = dr["TELEFONE"].ToString();
                }
            }

            return telefoneFornecedor;

        }


        public List<ModFornecedorTelefone> SelecionarTodos(int idFornecedor)
        {
            ComandoSQL = @"SELECT TAB_FORNECEDOR.NOME,TAB_FORNECEDOR_TELEFONE.* FROM TAB_FORNECEDOR_TELEFONE INNER JOIN TAB_FORNECEDOR 
                                        ON TAB_FORNECEDOR.ID = TAB_FORNECEDOR_TELEFONE.ID_FORNECEDOR";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@IDFORNECEDOR", Value = idFornecedor });

            //Conexão com o banco
            AcessoABase con = new AcessoABase(connectionString);
            List<ModFornecedorTelefone> lista = new List<ModFornecedorTelefone>();
            
            TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                while (dr.Read())
                {
                    ModFornecedor fornecedor = new ModFornecedor();
                    fornecedor.Id = Convert.ToInt32(dr["ID_FORNECEDOR"]);
                    fornecedor.Nome = dr["NOME"].ToString();

                    lista.Add(new ModFornecedorTelefone
                    {
                        FornecedorMod = fornecedor,

                        Id = Convert.ToInt32(dr["ID"]),
                        IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"]),
                        Tipo = tipoTeledone.SelecionarPorId(Convert.ToInt32(dr["TIPO"])),
                        Telefone = dr["TELEFONE"].ToString()
                    });
                }
                   
                     
            }
        

                return lista;
            
        }

        public List<ModFornecedorTelefone> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
        
    }
}


