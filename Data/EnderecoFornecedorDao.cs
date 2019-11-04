
using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
    public class EnderecoFornecedor : ICRUD<ModEnderecoFornecedor>
    {

        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private string ComandoSQL = string.Empty;

        public void Adicionar(ModEnderecoFornecedor entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_FORNECEDOR_ENDERECO(ID_FORNECEDOR,ENDERECO, BAIRRO, NUMERO, CIDADE, UF, CEP, COMPLEMENTO) " +
               "VALUES(@ID_FORNECEDOR, @ENDERECO, @BAIRRO, @NUMERO, @CIDADE, @UF, @CEP, @COMPLEMENTO)";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID_FORNECEDOR", Value = entidade.IdFornecedor });
            lst.Add(new SqlParameter { ParameterName = "@ENDERECO", Value = entidade.Endereco });
            lst.Add(new SqlParameter { ParameterName = "@BAIRRO", Value = entidade.Bairro });
            lst.Add(new SqlParameter { ParameterName = "@NUMERO", Value = entidade.Numero });
            lst.Add(new SqlParameter { ParameterName = "@CIDADE", Value = entidade.Cidade });
            lst.Add(new SqlParameter { ParameterName = "@UF", Value = entidade.UF });
            lst.Add(new SqlParameter { ParameterName = "@CEP", Value = entidade.CEP });
            lst.Add(new SqlParameter { ParameterName = "@COMPLEMENTO", Value = entidade.Complemento });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);

        }
        public void Atualizar(ModEnderecoFornecedor entidade)
        {

            ComandoSQL = @"UPDATE TAB_FORNECEDOR_ENDERECO SET   ENDERECO = @ENDERECO,BAIRRO = @BAIRRO," +
                         " NUMERO = @NUMERO, CIDADE = @CIDADE, UF = @UF, CEP = @CEP, COMPLEMENTO = @COMPLEMENTO  WHERE Id = @Id";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
            lst.Add(new SqlParameter { ParameterName = "@ENDERECO", Value = entidade.Endereco });
            lst.Add(new SqlParameter { ParameterName = "@BAIRRO", Value = entidade.Bairro });
            lst.Add(new SqlParameter { ParameterName = "@NUMERO", Value = entidade.Numero });
            lst.Add(new SqlParameter { ParameterName = "@CIDADE", Value = entidade.Cidade });
            lst.Add(new SqlParameter { ParameterName = "@UF", Value = entidade.UF });
            lst.Add(new SqlParameter { ParameterName = "@CEP", Value = entidade.CEP });
            lst.Add(new SqlParameter { ParameterName = "@COMPLEMENTO", Value = entidade.Complemento });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public void Deletar(int id)
        {
            ComandoSQL = @"DELETE FROM TAB_FORNECEDOR_ENDERECO WHERE ID = @Id";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public ModEnderecoFornecedor SelecionarPorId(int id)
        {

            // ComandoSQL = string.Format("SELECT ID,NOME,CNPJ,RAZAO_SOCIAL,TELEFONE,ENDERECO FROM TAB_FORNECEDOR_EMDERECO WHERE @ID = {0}", id); 
            ComandoSQL = "SELECT ID,ID_FORNECEDOR,ENDERECO, BAIRRO, NUMERO, CIDADE, UF, CEP, COMPLEMENTO FROM TAB_FORNECEDOR_ENDERECO WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            ModEnderecoFornecedor enderecoFornecedor = new ModEnderecoFornecedor();
            //tipo de retorno(tipo)
            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    enderecoFornecedor.Id = Convert.ToInt32(dr["ID"]);
                    enderecoFornecedor.IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"]);
                    enderecoFornecedor.Endereco = dr["ENDERECO"].ToString();
                    enderecoFornecedor.Bairro = dr["BAIRRO"].ToString();
                    enderecoFornecedor.Numero = dr["NUMERO"].ToString();
                    enderecoFornecedor.Cidade = dr["CIDADE"].ToString();
                    enderecoFornecedor.UF = dr["UF"].ToString();
                    enderecoFornecedor.CEP = dr["CEP"].ToString();
                    enderecoFornecedor.Complemento = dr["COMPLEMENTO"].ToString();

                }

            }

            return enderecoFornecedor;

        }

        public List<ModEnderecoFornecedor> SelecionarTodos(int idFornecedor)
        {
            ComandoSQL = @"SELECT TAB_FORNECEDOR.NOME,TAB_FORNECEDOR_ENDERECO.* FROM TAB_FORNECEDOR_ENDERECO INNER JOIN TAB_FORNECEDOR 
                                    ON TAB_FORNECEDOR.ID = TAB_FORNECEDOR_ENDERECO.ID_FORNECEDOR";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID_FORNECEDOR", Value = idFornecedor });

            //Conexão com o banco
            AcessoABase con = new AcessoABase(connectionString);
            List<ModEnderecoFornecedor> lista = new List<ModEnderecoFornecedor>();

            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                //Informações a ser apresentadas
                while (dr.Read())
                {
                    ModFornecedor fornecedor = new ModFornecedor();
                    fornecedor.Id = Convert.ToInt32(dr["ID_FORNECEDOR"]);
                    fornecedor.Nome = dr["NOME"].ToString();

                    lista.Add(new ModEnderecoFornecedor
                    {
                        FornecedorMod = fornecedor,

                        Id = Convert.ToInt32(dr["ID"]),
                        IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"]),
                        Endereco = dr["ENDERECO"].ToString(),
                        Bairro = dr["BAIRRO"].ToString(),
                        Numero = dr["NUMERO"].ToString(),
                        Cidade = dr["CIDADE"].ToString(),
                        UF = dr["UF"].ToString(),
                        CEP = dr["CEP"].ToString(),
                        Complemento = dr["COMPLEMENTO"].ToString(),

                    });

                }
            }
            return lista;
        }

        public List<ModEnderecoFornecedor> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}




