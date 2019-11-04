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
    public class ItemNotaFiscalDao : ICRUD<ModItemNotaFiscal>
    {
        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        private string ComandoSQL = string.Empty;


        public void Adicionar(ModItemNotaFiscal entidade)
        {
            ComandoSQL = @"INSERT INTO TAB_ITEM_NOTA_FISCAL(ID_NOTA_FISCAL,ID_PRODUTO, QTDE, VALOR) " +
               "VALUES(@ID_NOTA_FISCAL,@ID_PRODUTO,@QTDE,@VALOR)";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID_NOTA_FISCAL", Value = entidade.IdNotaFiscal });
            lst.Add(new SqlParameter { ParameterName = "@ID_PRODUTO", Value = entidade.IdProduto });
            lst.Add(new SqlParameter { ParameterName = "@QTDE", Value = entidade.Quantidade });
            lst.Add(new SqlParameter { ParameterName = "@VALOR", Value = entidade.Valor });


            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public void Atualizar(ModItemNotaFiscal entidade)
        {
            ComandoSQL = @"UPDATE TAB_ITEM_NOTA_FISCAL SET  ID_PRODUTO = @ID_PRODUTO, QTDE = @QTDE, VALOR = @VALOR WHERE ID = @ID";

            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
            lst.Add(new SqlParameter { ParameterName = "@ID_PRODUTO", Value = entidade.IdProduto });
            //lst.Add(new SqlParameter { ParameterName = "@NOME", Value = entidade.Produto.Nome });
            lst.Add(new SqlParameter { ParameterName = "@QTDE", Value = entidade.Quantidade });
            lst.Add(new SqlParameter { ParameterName = "@VALOR", Value = entidade.Valor });


            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public void Deletar(int id)
        {
            ComandoSQL = @"DELETE FROM TAB_ITEM_NOTA_FISCAL WHERE ID = @Id";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            AcessoABase con = new AcessoABase(connectionString);
            con.ExecutarComando(ComandoSQL, lst);
        }

        public ModItemNotaFiscal SelecionarPorId(int id)
        {
            ComandoSQL = @"SELECT * FROM TAB_ITEM_NOTA_FISCAL WHERE ID = @ID";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            ModItemNotaFiscal itemNotaFiscal = new ModItemNotaFiscal();
            AcessoABase con = new AcessoABase(connectionString);

            using (SqlDataReader dr = con.ComandoSelecao(ComandoSQL, lst))
            {
                dr.Read();
                if (dr.HasRows)
                {
                    itemNotaFiscal.Id = Convert.ToInt32(dr["ID"].ToString());
                    itemNotaFiscal.IdNotaFiscal = Convert.ToInt32(dr["ID_NOTA_FISCAL"].ToString());
                    itemNotaFiscal.IdProduto = Convert.ToInt32(dr["ID_PRODUTO"].ToString());
                    itemNotaFiscal.Quantidade = Convert.ToInt32(dr["QTDE"].ToString());
                    itemNotaFiscal.Valor = Convert.ToDouble(dr["VALOR"].ToString());

                }

            }

            return itemNotaFiscal;

        }

        public List<ModItemNotaFiscal> SelecionarTodos()
        {
            List<ModItemNotaFiscal> lst = new List<ModItemNotaFiscal>();
            ComandoSQL = @"SELECT TAB_PRODUTO.PRO_NOME,TAB_NOTA_FISCAL.NUMERO,TAB_ITEM_NOTA_FISCAL.* FROM TAB_ITEM_NOTA_FISCAL INNER JOIN TAB_PRODUTO ON TAB_ITEM_NOTA_FISCAL.ID_PRODUTO =  TAB_PRODUTO.ID 
                                        INNER JOIN TAB_NOTA_FISCAL ON TAB_ITEM_NOTA_FISCAL.ID_NOTA_FISCAL =  TAB_NOTA_FISCAL.ID";

            
            //Conexão com o banco
            AcessoABase acesso = new AcessoABase(connectionString);
            
            using (SqlDataReader dr = acesso.ComandoSelecao(ComandoSQL, new List<SqlParameter>()))
            {
                while (dr.Read())
                {
                    ModNotaFiscal nota = new ModNotaFiscal();
                    nota.Id = Convert.ToInt32(dr["ID_NOTA_FISCAL"]);
                    nota.Numero = dr["NUMERO"].ToString();
                    ModProduto produto = new ModProduto();
                    produto.Id = Convert.ToInt32(dr["ID_PRODUTO"]);
                    produto.Pro_Nome = dr["PRO_NOME"].ToString();

                    lst.Add(new ModItemNotaFiscal
                    {
                        Produto = produto,
                        NotaFiscal = nota,


                        Id = Convert.ToInt32(dr["ID"]),
                        IdNotaFiscal = Convert.ToInt32(dr["ID_NOTA_FISCAL"]),
                        IdProduto = Convert.ToInt32(dr["ID_PRODUTO"]),
                        Quantidade = Convert.ToInt32(dr["QTDE"]),
                        Valor = Convert.ToDouble(dr["VALOR"])





                    }) ; 

                }

                return lst;

            }



        }
    }
}

                

           

        

    

