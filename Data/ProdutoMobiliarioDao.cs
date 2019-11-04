using Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace Data
{
    //public class ProdutoMobiliarioDao : ICRUD<ProdutoMobiliario>
   // {
    //    readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();

    //    private string ComandoSQL = string.Empty;
    //    public void Adicionar(ProdutoMobiliario entidade)
    //    {
           
    //        ComandoSQL = @"INSERT INTO DB_PRODUTO_IMOBILIARIO(ALTURA,COMPRIMENTO,TAMANHO) " +
    //            "VALUES(@ALTURA,@COMPRIMENTO,@TAMANHO)";

    //        List<SqlParameter> lst = new List<SqlParameter>();
    //        lst.Add(new SqlParameter { ParameterName = "@ALTURA", Value = entidade.Altuta });
    //        lst.Add(new SqlParameter { ParameterName = "@COMPRIMENTO", Value = entidade.Comprimento });
    //        lst.Add(new SqlParameter { ParameterName = "@TAMANHO", Value = entidade.Tamanho });

    //        ProdutoMobiliario prod = new ProdutoMobiliario();
    //        lst.Add(new SqlParameter { ParameterName = "@IMPOSTO", Value = prod.CalcularImposto(entidade.Preco) });


    //        AcessoABase con = new AcessoABase(connectionString);
    //        con.ExecutarComando(ComandoSQL, lst);
    //    }

    //    public void Atualizar(ProdutoMobiliario entidade)
    //    {
    //        ComandoSQL = @" UPDATE DB_PRODUTO_IMOBILIARIO SET ALTURA = @ALTURA, COMPRIMENTO = @COMPRIMENTO, TAMANHO = @TAMANHO WHERE ID = @ID";

    //        List<SqlParameter> lst = new List<SqlParameter>();
    //        lst.Add(new SqlParameter { ParameterName = "@ID", Value = entidade.Id });
    //        lst.Add(new SqlParameter { ParameterName = "@ALTURA", Value = entidade.Altuta });
    //        lst.Add(new SqlParameter { ParameterName = "@COMPRIMENTO", Value = entidade.Comprimento });
    //        lst.Add(new SqlParameter { ParameterName = "@TAMANHO", Value = entidade.Tamanho });

    //        AcessoABase con = new AcessoABase(connectionString);
    //        con.ExecutarComando(ComandoSQL, lst);
    //    }
    //    public void Deletar(int id)
    //    {
    //        ComandoSQL = @"DELETE FROM DB_PRODUTO_IMOBILIARIO WHERE ID = @ID";

    //        List<SqlParameter> lst = new List<SqlParameter>();
    //        lst.Add(new SqlParameter { ParameterName = "@ID", Value = id });

    //        AcessoABase con = new AcessoABase(connectionString);
    //        con.ExecutarComando(ComandoSQL, lst);
    //    }
    

    //    public ProdutoMobiliario SelecionarPorId(int id)
    //    {
    //        ComandoSQL = string.Format("SELECT ID, ALTURA,COMPRIMENTO,TAMANHO FROM DB_PRODUTO_IMOBILIARIO  WHERE ID = {0}", id);
    //        AcessoABase con = new AcessoABase(connectionString);
    //        //tipo de retorno(tipo)
    //        SqlDataReader selecProMob;
    //        var customer = new ProdutoMobiliario();
    //        selecProMob = con.ComandoSelecao(ComandoSQL, new List<SqlParameter>());

    //        while (selecProMob.Read())
    //        {
    //            customer.Id = int.Parse(selecProMob["ID"].ToString());
    //            customer.Nome = selecProMob["ALTURA"].ToString();
    //            customer.Tamanho = int.Parse(selecProMob["COMPRIMENTO"].ToString());
    //            customer.Quantidade = int.Parse(selecProMob["TAMANHO"].ToString());

    //        }

    //        return customer;
    //    }

    //    public List<ProdutoMobiliario> SelecionarTodos()
    //    {
    //        ComandoSQL = @"SELECT * FROM DB_PRODUTO_IMOBILIARIO ";
    //        List<SqlParameter> lst = new List<SqlParameter>();

    //        //Conexão com o banco
    //        AcessoABase con = new AcessoABase(connectionString);

    //        //Comando para recuperação de dados select
    //        SqlDataReader sprodutoMob;
    //        sprodutoMob = con.ComandoSelecao(ComandoSQL, lst);
    //        var lista = new List<ProdutoMobiliario>();
    //        //Informações a ser apresentadas
    //        while (sprodutoMob.Read())
    //        {

    //            var item = new ProdutoMobiliario
    //            {
    //                Id = sprodutoMob.GetInt32(0),
    //                Altuta = sprodutoMob.GetInt32(1),
    //                Comprimento = sprodutoMob.GetInt32(2),
    //                Tamanho = sprodutoMob.GetInt32(3),
    //            };

    //            lista.Add(item);
    //        }

    //        return lista;
    //    }
    //}
}
