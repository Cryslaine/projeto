using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace Data
{
    public class FornecedorDao : ICRUD<ModFornecedor>
    {
        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private string ComandoSQL = string.Empty;

        public void Adicionar(ModFornecedor entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_FORNECEDOR(RAZAO_SOCIAL,NOME,CNPJ) " +
                "VALUES(@RAZAO_SOCIAL,@NOME,@CNPJ)";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@Razao_Social", Value = entidade.RazaoSocial });
            lst.Add(new SqlParameter { ParameterName = "@NOME", Value = entidade.Nome });
            lst.Add(new SqlParameter { ParameterName = "@CNPJ", Value = entidade.Cnpj });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);

        }

        public void Atualizar(ModFornecedor entidade)
        {
            ComandoSQL = @"UPDATE TAB_FORNECEDOR SET RAZAO_SOCIAL= @RAZAO_SOCIAL,NOME = @NOME, CNPJ = @CNPJ WHERE Id = @Id";

         
            List<SqlParameter> lst = new List<SqlParameter>();
            TipoTelefoneDao tipoTeledone = new TipoTelefoneDao();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
            lst.Add(new SqlParameter { ParameterName = "@RAZAO_SOCIAL", Value = entidade.RazaoSocial });
            lst.Add(new SqlParameter { ParameterName = "@NOME", Value = entidade.Nome });
            lst.Add(new SqlParameter { ParameterName = "@CNPJ", Value = entidade.Cnpj });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);


        }

        public void Deletar(int id)
        {
            ComandoSQL = @"DELETE FROM TAB_FORNECEDOR WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);

        }


        public ModFornecedor SelecionarPorId(int id)
        {

            ComandoSQL = @"SELECT ID,RAZAO_SOCIAL,NOME, CNPJ FROM TAB_FORNECEDOR WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            ModFornecedor fornecedor = new ModFornecedor();
            AcessoABase con = new AcessoABase(connectionString);
            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    fornecedor.Id = Convert.ToInt32(dr["ID"]);
                    fornecedor.RazaoSocial = Convert.ToInt32(dr["RAZAO_SOCIAL"]).ToString();
                    fornecedor.Nome = dr["NOME"].ToString();
                    fornecedor.Cnpj = dr["CNPJ"].ToString();

                }
            }

            return fornecedor;
        }

        public List<ModFornecedor> SelecionarTodos()
        {
            List<ModFornecedor> lst = new List<ModFornecedor>();
            ComandoSQL = @"SELECT * FROM TAB_FORNECEDOR";

            AcessoABase acesso = new AcessoABase(connectionString);

            using (SqlDataReader dr = acesso.ComandoSelecao(ComandoSQL, new List<SqlParameter>()))
            {
                while (dr.Read())
                {
                    lst.Add(new ModFornecedor
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        RazaoSocial = dr["RAZAO_SOCIAL"].ToString(),
                        Nome = dr["NOME"].ToString(),
                        Cnpj = dr["CNPJ"].ToString()
                });
                }
            }
            return lst;
        }

        public ModFornecedor SelecionarPorCnpj(string Cnpj)
        {
            ComandoSQL = "SELECT ID, RAZAO_SOCIAL, NOME, CNPJ FROM TAB_FORNECEDOR WHERE CNPJ = @CNPJ";

            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter { ParameterName = "@CNPJ", Value = Cnpj });

            AcessoABase con = new AcessoABase(connectionString);

            var customer = new ModFornecedor();

            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lstParametros))
            {
                
                while (dr.Read())
                {

                    customer.Id = int.Parse(dr["ID"].ToString());
                    customer.RazaoSocial = dr["RAZAO_SOCIAL"].ToString();
                    customer.Nome = dr["NOME"].ToString();
                    customer.Cnpj = dr["CNPJ"].ToString();


                }
            }

                return customer;

        }

    }
}
