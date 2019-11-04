using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class ProdutoDao : ICRUD<ModProduto>

    {
        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private string ComandoSQL = string.Empty;
        public void Adicionar(ModProduto entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_PRODUTO(ID_FORNECEDOR,PRO_NOME,PRECO,TAMANHO,PESO,COR,QUANTIDADE) " +
                 "VALUES(@ID_FORNECEDOR,@PRO_NOME,@PRECO,@TAMANHO,@PESO,@COR,@QUANTIDADE)";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID_FORNECEDOR", Value = entidade.IdFornecedor });
            lst.Add(new SqlParameter { ParameterName = "@PRO_NOME", Value = entidade.Pro_Nome });
            lst.Add(new SqlParameter { ParameterName = "@PRECO", Value = entidade.Preco });
            lst.Add(new SqlParameter { ParameterName = "@TAMANHO", Value = entidade.Tamanho });
            lst.Add(new SqlParameter { ParameterName = "@PESO", Value = entidade.Peso });
            lst.Add(new SqlParameter { ParameterName = "@COR", Value = entidade.Cor });
            lst.Add(new SqlParameter { ParameterName = "@QUANTIDADE", Value = entidade.Quantidade });




            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }



        public void Atualizar(ModProduto entidade)
        {
            ComandoSQL = @"UPDATE TAB_PRODUTO SET  PRO_NOME = @PRO_NOME,ID_FORNECEDOR = @ID_FORNECEDOR, PRECO = @PRECO, TAMANHO = @TAMANHO, " +
                           "PESO = @PESO, COR = @COR, QUANTIDADE = @QUANTIDADE WHERE Id = @Id";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
            lst.Add(new SqlParameter { ParameterName = "@ID_FORNECEDOR", Value = entidade.IdFornecedor });
            lst.Add(new SqlParameter { ParameterName = "@PRO_NOME", Value = entidade.Pro_Nome });
            lst.Add(new SqlParameter { ParameterName = "@PRECO", Value = entidade.Preco });
            lst.Add(new SqlParameter { ParameterName = "@TAMANHO", Value = entidade.Tamanho });
            lst.Add(new SqlParameter { ParameterName = "@PESO", Value = entidade.Peso });
            lst.Add(new SqlParameter { ParameterName = "@COR", Value = entidade.Cor });
            lst.Add(new SqlParameter { ParameterName = "@QUANTIDADE", Value = entidade.Quantidade });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);

        }

        public void Deletar(int id)
        {
            ComandoSQL = @"DELETE FROM TAB_PRODUTO WHERE ID = @Id";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }


        public ModProduto SelecionarPorId(int id)
        {
            ComandoSQL = @"SELECT ID,ID_FORNECEDOR, PRO_NOME, PRECO, TAMANHO, PESO, COR, QUANTIDADE FROM TAB_PRODUTO WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            ModProduto produto = new ModProduto();
            AcessoABase con = new AcessoABase(connectionString);

            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    produto.Id = Convert.ToInt32(dr["ID"].ToString());
                    produto.IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"].ToString());
                    produto.Pro_Nome = dr["PRO_NOME"].ToString();
                    produto.Preco = Double.Parse(dr["PRECO"].ToString());
                    produto.Tamanho = int.Parse(dr["TAMANHO"].ToString());
                    produto.Peso = int.Parse(dr["PESO"].ToString());
                    produto.Cor = dr["COR"].ToString();
                    produto.Quantidade = int.Parse(dr["QUANTIDADE"].ToString());
                }
            }


            return produto;
        }


        public List<ModProduto> SelecionarTodos()
        {
            List<ModProduto> lst = new List<ModProduto>();
            ComandoSQL = @"SELECT P.NOME as FN ,B.*  FROM TAB_PRODUTO  B INNER JOIN TAB_FORNECEDOR as P ON B.ID_FORNECEDOR = P.ID ";


            //Conexão com o banco
            AcessoABase acesso = new AcessoABase(connectionString);


            using (SqlDataReader dr = acesso.ComandoSelecao(ComandoSQL, new List<SqlParameter>()))
            {
                while (dr.Read())
                {
                    ModFornecedor forn = new ModFornecedor();
                    forn.Id = Convert.ToInt32(dr["ID"]);
                    forn.Nome = dr["FN"].ToString();

                    lst.Add(new ModProduto
                    {
                        FornMOD = forn,

                        Id = int.Parse(dr["ID"].ToString()),
                        IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"].ToString()),
                        Pro_Nome = dr["PRO_NOME"].ToString(),
                        Preco = Double.Parse(dr["PRECO"].ToString()),
                        Tamanho = int.Parse(dr["TAMANHO"].ToString()),
                        Peso = int.Parse(dr["PESO"].ToString()),
                        Cor = dr["COR"].ToString(),
                        Quantidade = int.Parse(dr["QUANTIDADE"].ToString())


                    });
                }
            }
            return lst;



        }
        //public ModProduto SelecionarPorNome(string Nome)
        //{
        //    ComandoSQL = @"SELECT ID,ID_FORNECEDOR, NOME, PRECO, TAMANHO, PESO, COR, QUANTIDADE FROM TAB_PRODUTO WHERE NOME LIKE '%' + @NOME + '%'";
        //    List<SqlParameter> lst = new List<SqlParameter>();
        //    lst.Add(new SqlParameter { ParameterName = "@NOME", Value = Nome });

        //    ModProduto produto = new ModProduto();
        //    AcessoABase con = new AcessoABase(connectionString);

        //    using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
        //    {
        //        dr.Read();
        //        if (dr.HasRows)
        //        {
        //            produto.Id = Convert.ToInt32(dr["ID"].ToString());
        //            produto.IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"].ToString());
        //            produto.Nome = dr["NOME"].ToString();
        //            produto.Preco = Double.Parse(dr["PRECO"].ToString());
        //            produto.Tamanho = int.Parse(dr["TAMANHO"].ToString());
        //            produto.Peso = int.Parse(dr["PESO"].ToString());
        //            produto.Cor = dr["COR"].ToString();
        //            produto.Quantidade = int.Parse(dr["QUANTIDADE"].ToString());
        //        }
        //    }


        //    return produto;
        //}


        public List<ModProduto> SelecionarPorNome(string Pro_Nome)
        {
            ComandoSQL = @"SELECT  ID,ID_FORNECEDOR, PRO_NOME, PRECO, TAMANHO, PESO, COR, QUANTIDADE FROM TAB_PRODUTO  WHERE PRO_NOME LIKE '%' + @PRO_NOME + '%'";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@PRO_NOME", Value = Pro_Nome });

            // ModProduto produto = new ModProduto();
            AcessoABase acesso = new AcessoABase(connectionString);
            List<ModProduto> lista = new List<ModProduto>();
            using (SqlDataReader dr = acesso.ComandoSelecao(ComandoSQL, lst))
            {
                while (dr.Read())
                {
                    lista.Add(new ModProduto
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        IdFornecedor = Convert.ToInt32(dr["ID_FORNECEDOR"]),
                        Pro_Nome = dr["PRO_NOME"].ToString(),
                        Preco = Double.Parse(dr["PRECO"].ToString()),
                        Tamanho = Convert.ToInt32(dr["TAMANHO"].ToString()),
                        Peso = Convert.ToInt32(dr["PESO"].ToString()),
                        Cor = dr["COR"].ToString(),
                        Quantidade = Convert.ToInt32(dr["QUANTIDADE"].ToString())
                    });

                }
            }



            return lista;

        }

    }
}
