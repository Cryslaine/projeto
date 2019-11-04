using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
    public class TipoTelefoneDao : ICRUD<Modelo.TipoTelefone>
    {
        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private string ComandoSQL = string.Empty;


        public void Adicionar(Modelo.TipoTelefone entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_TIPO_TELEFONE(ID,TIPO) VALUES (@ID,@TIPO)";
            List<SqlParameter> lst = new List<SqlParameter>();

            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
            lst.Add(new SqlParameter { ParameterName = "@TIPO", Value = entidade.Descricao });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public void Atualizar(Modelo.TipoTelefone entidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Modelo.TipoTelefone SelecionarPorId(int id)
        {
            Modelo.TipoTelefone mTipoTelefone = new Modelo.TipoTelefone();
            ComandoSQL = @"SELECT * FROM TAB_TIPO_TELEFONE(NOLOCK) WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });
            AcessoABase acesso = new AcessoABase(connectionString);

            using (SqlDataReader dr = acesso.ComandoSelecao(ComandoSQL, lst))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    mTipoTelefone.Id = Convert.ToInt32(dr["ID"]);
                    mTipoTelefone.Descricao = dr["TIPO"].ToString();
                }
            }

            return mTipoTelefone;


        }

        public List<Modelo.TipoTelefone> SelecionarTodos()
        {
            List<Modelo.TipoTelefone> lst = new List<TipoTelefone>();
            ComandoSQL = @"SELECT * FROM TAB_TIPO_TELEFONE(NOLOCK)";

            AcessoABase acesso = new AcessoABase(connectionString);

            using (SqlDataReader dr = acesso.ComandoSelecao(ComandoSQL, new List<SqlParameter>()))
            {
                while (dr.Read())
                {
                    lst.Add(new TipoTelefone
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Descricao = dr["TIPO"].ToString()
                    });
                }
            }
            return lst;
        }

    }
}
