using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ITC__vol_0_
{
   public class ConnectionSql
    {
        private string server, password, user, database , port;

     private MySqlConnection con;
       private MySqlCommand com;


        public ConnectionSql(string server ,string port, string password,string user , string database )
        {
            this.server = server;
            this.password = password;
            this.user = user;
            this.database = database;
            this.port = port;
            Connecte();
        }

        public void  Connecte()
        {
            try
            {
                string connectionString = @"server =" + server + ";port = "+port+" ; uid =" + user + ";pwd=" + password + ";database =" + database + ";charset = utf8;SslMode=none;";
                con = new MySqlConnection(connectionString);
               con.Open();
              //  com = con.CreateCommand();

            }
            catch (SqlException e)
            {
                ErorForm w = new ErorForm(e.Message);
                w.Show();
            }
        }

        public DataTable ReturnVal(string command)
        {
           // con.Open();
           // com = con.CreateCommand();
            DataTable r= new DataTable();
          //  com.CommandType = CommandType.TableDirect;
          //  com.CommandText = command;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command, con);
            adapter.Fill(r);
           

            return r;
        }

        public void ExcuteCommand(string command)
        {
           //con.Open();
            com = con.CreateCommand();
            com.CommandText = command;
            com.CommandType = CommandType.Text;
      
            com.ExecuteNonQuery();
        }
        public void CloseConnection()
        {
            con.Close();
            
        }
   
    }
}
