using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Data
{
    // execução
    public class AcessoABase

    {

       private SqlConnection conn = new SqlConnection();
        private readonly string connectionString;


        public AcessoABase(string connection)
        {
           connectionString = connection;
        }
        private void ConectaBanco()
        {

             

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
          

            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public void ExecutarComando(string comando, List<SqlParameter> lstParam)
        {
            //aqui efetuamos a conexão com o banco de dados
            ConectaBanco();

            //atribuo o comando SQL e a string de conexão
            using (SqlCommand cmd = new SqlCommand(comando, conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                //aqui percorro a lista de parâmetros para
                //que serão utilizados no comando Sql
                foreach (SqlParameter param in lstParam)
                {
                    cmd.Parameters.Add(param);
                }

                //Executa o comando no banco de dados
                cmd.ExecuteNonQuery();
            } 
            
        }


        public SqlDataReader ComandoSelecao(string comando, List<SqlParameter> lstParam)
        {
            //aqui efetuamos a conexão com o banco de dados
            ConectaBanco();


            //atribuo o comando SQL e a string de conexão

            SqlCommand cmd = new SqlCommand(comando, conn);
            cmd.CommandType = System.Data.CommandType.Text;



            //aqui percorro a lista de parâmetros para
            //que serão utilizados no comando Sql
            foreach (SqlParameter param in lstParam)
            {
                //Executa o comando no banco de dados
                cmd.Parameters.Add(param);
            }

            


            return cmd.ExecuteReader();
        }

    }
}