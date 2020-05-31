using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class AcessoBancoDados
    {
        private OleDbConnection conn;
        private DataTable data;
        private OleDbDataAdapter da;
        private OleDbDataReader dr;
        private OleDbCommandBuilder cb;
        private  OleDbCommand  cmd;

        public void Conectar()
        {
            //if (conn != null)
            //    conn.Close();
            //string connStr = string.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, user, password, database);
            //string connStr = "datasource=localhost; port=3306; database=bd_parque_de_estacionamento; username=root; password=1993";

            string connStr=@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Joao Eduardo\Documents\Visual Studio 2012\Projects\PARQUE_ESTACIONAMENTO_VEICULO\BD_Parque_De_Estacionamento_De_Carro.accdb"; 
            try
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }

            catch (OleDbException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Metdo para executar comandos SQL

        public void ExecutarComandoSQL(string comandoSql)
        {
            OleDbCommand comando = new OleDbCommand(comandoSql, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        // Metodo para preencher os dados no datagrid

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new OleDbDataAdapter(sql, conn);
            cb = new OleDbCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        // Metodo Para Retronar um Id numerico
        public int RetDataTable_Id_Numerico(string sql)
        {
            data = new DataTable();

            da = new OleDbDataAdapter();

            cmd = new OleDbCommand(sql, conn);
            da.SelectCommand = cmd;

            da.Fill(data);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Metodo para fazer a leitura de dados da tabela 

        public OleDbDataReader RetDataReader(string sql)
        {
            OleDbCommand comando = new OleDbCommand(sql, conn);
            dr = comando.ExecuteReader();
            dr.Read();
            return dr;

            /*OleDbCommand comando = new OleDbCommand(sql, conn);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comando;
            OleDbDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;*/
        }
    }
}
