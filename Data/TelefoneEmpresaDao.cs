using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{

    public class EmpresaTelefone : ICRUD<ModEmpresaTelefone>
    {

        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private string ComandoSQL = string.Empty;
        public void Adicionar(ModEmpresaTelefone entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_TELEFONE_EMPRESA(TIPO,ID_EMPRESA, TELEFONE) VALUES(@TIPO,@ID_EMPRESA, @TELEFONE)";
            TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@TIPO", Value = entidade.Tipo.Id });
            lst.Add(new SqlParameter { ParameterName = "@ID_EMPRESA", Value = entidade.IdEmpresa });
            lst.Add(new SqlParameter { ParameterName = "@TELEFONE", Value = entidade.Telefone });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public void Atualizar(ModEmpresaTelefone entidade)
        {
            ComandoSQL = @"UPDATE TAB_TELEFONE_EMPRESA  SET  TIPO = @TIPO, TELEFONE = @TELEFONE  
                            WHERE Id = @Id";
             TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
            lst.Add(new SqlParameter { ParameterName = "@TIPO", Value = entidade.Tipo.Id});
            lst.Add(new SqlParameter { ParameterName = "@TELEFONE", Value = entidade.Telefone });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }
    

    public void Deletar(int id)
    {
        ComandoSQL = @"DELETE FROM TAB_TELEFONE_EMPRESA WHERE ID = @Id";

        List<SqlParameter> lst = new List<SqlParameter>();
        lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

        AcessoABase con = new AcessoABase(connectionString);
        con.ExecutarComando(ComandoSQL, lst);
    }


    public ModEmpresaTelefone SelecionarPorId(int id)
    {
        ComandoSQL = "SELECT ID,TIPO,ID_EMPRESA, TELEFONE FROM TAB_TELEFONE_EMPRESA WHERE ID = @ID";
        List<SqlParameter> lst = new List<SqlParameter>();
        lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

        AcessoABase con = new AcessoABase(connectionString);
        ModEmpresaTelefone telefoneEmpresa = new ModEmpresaTelefone();

        TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
        using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
        {
            dr.Read();
            if (dr.HasRows)
            {
                telefoneEmpresa.Id = Convert.ToInt32(dr["ID"]);
                telefoneEmpresa.IdEmpresa = Convert.ToInt32(dr["ID_EMPRESA"]);
                telefoneEmpresa.Tipo = tipoTeledone.SelecionarPorId(Convert.ToInt32(dr["TIPO"]));
                telefoneEmpresa.Telefone = dr["TELEFONE"].ToString();
            }
        }

        return telefoneEmpresa;
    }
        public List<ModEmpresaTelefone> SelecionarTodos(int idEmpresa)
        {
            ComandoSQL = @"SELECT * FROM TAB_TELEFONE_EMPRESA WHERE ID_EMPRESA = @IDEMPRESA ";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@IDEMPRESA", Value = idEmpresa });

            //Conexão com o banco
            AcessoABase con = new AcessoABase(connectionString);
            List<ModEmpresaTelefone> lista = new List<ModEmpresaTelefone>();

            TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                while (dr.Read())
                {
                    lista.Add(new ModEmpresaTelefone
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        IdEmpresa = Convert.ToInt32(dr["ID_EMPRESA"]),
                        Tipo = tipoTeledone.SelecionarPorId(Convert.ToInt32(dr["TIPO"])),
                        Telefone = dr["TELEFONE"].ToString()
                    });
                }
            }

            return lista;
        }

        public List<ModEmpresaTelefone> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
