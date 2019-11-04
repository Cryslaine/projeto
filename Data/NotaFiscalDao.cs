using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
    public class NotaFiscalDao : ICRUD<ModNotaFiscal>
    {
        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private string ComandoSQL = string.Empty;

        public void Adicionar(ModNotaFiscal entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_NOTA_FISCAL( NUMERO,ID_PRODUTO, VALOR, ID_RAZAO_SOCIAL) " +
                 "VALUES(@NUMERO,@ID_PRODUTO,@VALOR,@ID_RAZAO_SOCIAL)";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@NUMERO", Value = entidade.Numero });
            lst.Add(new SqlParameter { ParameterName = "@ID_PRODUTO", Value = entidade.IdProduto });
            lst.Add(new SqlParameter { ParameterName = "@VALOR", Value = entidade.Valor });
            lst.Add(new SqlParameter { ParameterName = "@ID_RAZAO_SOCIAL", Value = entidade.RazaoSocial });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);

        }

        public void Atualizar(ModNotaFiscal entidade)
        {
            ComandoSQL = @"UPDATE TAB_NOTA_FISCAL SET NUMERO = @NUMERO ,ID_PRODUTO = @ID_PRODUTO, VALOR = @VALOR , ID_RAZAO_SOCIAL = @ID_RAZAO_SOCIAL  " +
                          " WHERE Id = @Id";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id});
            lst.Add(new SqlParameter { ParameterName = "@NUMERO", Value = entidade.Numero });
            lst.Add(new SqlParameter { ParameterName = "@ID_PRODUTO", Value = entidade.IdProduto });
            lst.Add(new SqlParameter { ParameterName = "@VALOR", Value = entidade.Valor });
            lst.Add(new SqlParameter { ParameterName = "@ID_RAZAO_SOCIAL", Value = entidade.RazaoSocial });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public void Deletar(int id)
        {
            ComandoSQL = @"DELETE FROM TAB_NOTA_FISCAL WHERE ID = @Id";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public ModNotaFiscal SelecionarPorId(int id)
        {
            ComandoSQL = @"SELECT ID,ID_PRODUTO, NUMERO, VALOR, ID_RAZAO_SOCIAL FROM TAB_NOTA_FISCAL WHERE ID = @ID";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            ModNotaFiscal notaFiscal = new ModNotaFiscal();
            AcessoABase con = new AcessoABase(connectionString);

            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    notaFiscal.Id = Convert.ToInt32(dr["ID"].ToString());
                    notaFiscal.Numero = dr["NUMERO"].ToString();
                    notaFiscal.Id = Convert.ToInt32(dr["ID_PRODUTO"].ToString());
                    notaFiscal.Valor = Convert.ToDouble(dr["VALOR"].ToString());
                    notaFiscal.RazaoSocial = Convert.ToInt32( dr["ID_RAZAO_SOCIAL)"].ToString());
                }
            }


            return notaFiscal;


        }

        public List<ModNotaFiscal> SelecionarTodos()
        {
            List<ModNotaFiscal> lst = new List<ModNotaFiscal>();
            ComandoSQL = @"SELECT * FROM TAB_NOTA_FISCAL ";



            AcessoABase acesso = new AcessoABase(connectionString);

            using (SqlDataReader dr = acesso.ComandoSelecao(ComandoSQL, new List<SqlParameter>()))
            {
                while (dr.Read())
                {
                    lst.Add(new ModNotaFiscal
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Numero = dr["NUMERO"].ToString(),
                        IdProduto = Convert.ToInt32(dr["ID_PRODUTO"]),
                        Valor = Convert.ToDouble(dr["VALOR"]),
                        RazaoSocial = Convert.ToInt32(dr["ID_RAZAO_SOCIAL"])
                    });
                }
            }

            return lst;
        }

        public ModNotaFiscal SelecionarPorNumeroDaNota(int Numero)
        {

            ComandoSQL = "SELECT ID,NUMERO,ID_PRODUTO, VALOR, ID_RAZAO_SOCIAL FROM TAB_NOTA_FISCAL WHERE NUMERO = @NUMERO";

            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter { ParameterName = "@NUMERO", Value = Numero });

            ModNotaFiscal notaFiscal = new ModNotaFiscal();
            AcessoABase con = new AcessoABase(connectionString);

            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lstParametros))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    notaFiscal.Id = Convert.ToInt32(dr["ID"].ToString());
                    notaFiscal.IdProduto = Convert.ToInt32(dr["ID_PRODUTO"].ToString());
                    notaFiscal.Numero = dr["NUMERO"].ToString();
                    notaFiscal.Valor = Convert.ToDouble(dr["VALOR"].ToString());
                    notaFiscal.RazaoSocial = Convert.ToInt32(dr["ID_RAZAO_SOCIAL"].ToString());
                }
            }


            return notaFiscal;


        }
    }
}

