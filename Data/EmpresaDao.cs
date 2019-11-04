using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace Data
{
    public class EmpresaDao : ICRUD<ModEmpresa>
    {

        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
 
        private string ComandoSQL = string.Empty;
        public void Adicionar(ModEmpresa entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_EMPRESA(NOME_RAZAO_SOCIAL,NOME_FANTASIA,CNPJ,ENDERECO, NUMERO,BAIRRO, CIDADE, UF, CEP, COMPLEMENTO) " +
                  "VALUES(@NOME_RAZAO_SOCIAL,@NOME_FANTASIA,@CNPJ,@ENDERECO, @NUMERO, @BAIRRO, @CIDADE, @UF, @CEP, @COMPLEMENTO)";

            List<SqlParameter> lst = new List<SqlParameter>();


            lst.Add(new SqlParameter { ParameterName = "@NOME_RAZAO_SOCIAL", Value = entidade.NomeRazaoSocial });
            lst.Add(new SqlParameter { ParameterName = "@NOME_FANTASIA", Value = entidade.NomeFantasia });
            lst.Add(new SqlParameter { ParameterName = "@CNPJ", Value = entidade.Cnpj });
            lst.Add(new SqlParameter { ParameterName = "@ENDERECO", Value = entidade.Endereco });
            lst.Add(new SqlParameter { ParameterName = "@NUMERO", Value = entidade.Numero });
            lst.Add(new SqlParameter { ParameterName = "@BAIRRO", Value = entidade.Bairro });
            lst.Add(new SqlParameter { ParameterName = "@CIDADE", Value = entidade.Cidade });
            lst.Add(new SqlParameter { ParameterName = "@UF", Value = entidade.UF });
            lst.Add(new SqlParameter { ParameterName = "@CEP", Value = entidade.CEP });
            lst.Add(new SqlParameter { ParameterName = "@COMPLEMENTO", Value = entidade.Complemento });

            //Conexão com o banco
            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);


        }

        public void Atualizar(ModEmpresa entidade)
        {
            ComandoSQL = @"UPDATE TAB_EMPRESA SET  NOME_RAZAO_SOCIAL = @NOME_RAZAO_SOCIAL , NOME_FANTASIA = @NOME_FANTASIA, CNPJ = @CNPJ," +
                              " ENDERECO = @ENDERECO, BAIRRO = @BAIRRO, CIDADE = @CIDADE," + "" +
                              " NUMERO = @NUMERO, UF = @UF, CEP = @CEP, COMPLEMENTO = @COMPLEMENTO WHERE ID = @ID ";

            List<SqlParameter> lst = new List<SqlParameter>();

            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
            lst.Add(new SqlParameter { ParameterName = "@NOME_RAZAO_SOCIAL", Value = entidade.NomeRazaoSocial });
            lst.Add(new SqlParameter { ParameterName = "@NOME_FANTASIA", Value = entidade.NomeFantasia });
            lst.Add(new SqlParameter { ParameterName = "@CNPJ", Value = entidade.Cnpj });
            lst.Add(new SqlParameter { ParameterName = "@ENDERECO", Value = entidade.Endereco });
            lst.Add(new SqlParameter { ParameterName = "@NUMERO", Value = entidade.Numero });
            lst.Add(new SqlParameter { ParameterName = "@BAIRRO", Value = entidade.Bairro });
            lst.Add(new SqlParameter { ParameterName = "@CIDADE", Value = entidade.Cidade });
            lst.Add(new SqlParameter { ParameterName = "@UF", Value = entidade.UF });
            lst.Add(new SqlParameter { ParameterName = "@CEP", Value = entidade.CEP });
            lst.Add(new SqlParameter { ParameterName = "@COMPLEMENTO", Value = entidade.Complemento });

            //Conexão com o banco
            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);

        }

        public void Deletar(int id)
        {
            ComandoSQL = @"DELETE FROM TAB_EMPRESA WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public ModEmpresa SelecionarPorId(int id)
        {
            ComandoSQL = string.Format("SELECT NOMERAZAOSOCIAL,NOME_FANTASIA,CNPJ,ENDERECO, BAIRRO, CIDADE, NUMERO, UF, CEP, COMPLEMENTO FROM TAB_EMPRESA WHERE @ID = {0}", id);
            AcessoABase con = new AcessoABase(connectionString);
            //tipo de retorno(tipo)
            SqlDataReader selecEmp;
            var customer = new ModEmpresa();
            selecEmp = con.ComandoSelecao(ComandoSQL, new List<SqlParameter>());

            while (selecEmp.Read())
            {
                customer.Id = int.Parse(selecEmp["ID"].ToString());
                customer.NomeRazaoSocial = selecEmp["NOMERAZAOSOCIAL"].ToString();
                customer.NomeFantasia = selecEmp["NOME_FANTASIA"].ToString();
                customer.Cnpj = selecEmp["CNPJ"].ToString();
                customer.Endereco = selecEmp["ENDERECO"].ToString();
                customer.Bairro = selecEmp["BAIRRO"].ToString();
                customer.Cidade = selecEmp["CIDADE"].ToString();
                customer.Numero = selecEmp["NUMERO"].ToString();
                customer.UF = selecEmp["UF"].ToString();
                customer.CEP = selecEmp["CEP"].ToString();
                customer.Complemento = selecEmp["COMPLEMENTO"].ToString();



            }

            return customer;
        }

        public List<ModEmpresa> SelecionarTodos()
        {
            ComandoSQL = @"SELECT * FROM TAB_EMPRESA ";
            List<SqlParameter> lst = new List<SqlParameter>();

            //Conexão com o banco
            AcessoABase con = new AcessoABase(connectionString);

            //Comando para recuperação de dados select
            SqlDataReader sempresa;
            sempresa = con.ComandoSelecao(ComandoSQL, lst);
            var lista = new List<ModEmpresa>();
            //Informações a ser apresentadas
            while (sempresa.Read())
            {

                var item = new ModEmpresa
                {

                    Id = sempresa.GetInt32(0),
                    NomeRazaoSocial = sempresa.GetString(1),
                    NomeFantasia = sempresa.GetString(2),
                    Cnpj = sempresa.GetString(3),
                    Endereco = sempresa.GetString(4),
                    Numero = sempresa.GetString(5),
                    Bairro = sempresa.GetString(6),
                    Cidade = sempresa.GetString(7),
                    UF = sempresa.GetString(8),
                    CEP = sempresa.GetString(9),
                    Complemento = sempresa.GetString(10),
                };


                lista.Add(item);
            }

            return lista;
        }
        public ModEmpresa SelecionarPorCnpj(string Cnpj)
        {
            ComandoSQL = "SELECT ID,NOME_RAZAO_SOCIAL,NOME_FANTASIA,CNPJ,ENDERECO, BAIRRO, CIDADE, NUMERO, UF, CEP, COMPLEMENTO FROM TAB_EMPRESA  WHERE CNPJ = @CNPJ";


            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter { ParameterName = "@CNPJ", Value = Cnpj });

            AcessoABase con = new AcessoABase(connectionString);

            var customer = new ModEmpresa();

            using (SqlDataReader selecEmp = con.ComandoSelecao(ComandoSQL, lstParametros))

            {

                while (selecEmp.Read())
                {

                    customer.Id = int.Parse(selecEmp["ID"].ToString());
                    customer.NomeRazaoSocial = selecEmp["NOME_RAZAO_SOCIAL"].ToString();
                    customer.NomeFantasia = selecEmp["NOME_FANTASIA"].ToString();
                    customer.Cnpj = selecEmp["CNPJ"].ToString();
                    customer.Endereco = selecEmp["ENDERECO"].ToString();
                    customer.Bairro = selecEmp["BAIRRO"].ToString();
                    customer.Cidade = selecEmp["CIDADE"].ToString();
                    customer.Numero = selecEmp["NUMERO"].ToString();
                    customer.UF = selecEmp["UF"].ToString();
                    customer.CEP = selecEmp["CEP"].ToString();
                    customer.Complemento = selecEmp["COMPLEMENTO"].ToString();



                }

            }
            return customer;
        }
    }
}





