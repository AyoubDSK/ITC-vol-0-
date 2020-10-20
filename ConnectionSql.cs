using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITC__vol_0_ {
    public class ConnectionSql {
        private string server = "localhost", password="12345", user="root", database= "itc", port="3306";

        private MySqlConnection con;
        private MySqlCommand com;
        public ConnectionSql (string server, string password, string user, string database, string port) {
            this.server = server;
            this.password = password;
            this.user = user;
            this.database = database;
            this.port = port;

            Connecte ();
        }
        public ConnectionSql () {


            /*
            try {

                string[] set = Settingroot.Open ();

                server = set[0];
                user = set[1];
                port = set[2];
                password = set[3];
                database = set[4];

            } catch (Exception ee) {
                setting setting = new setting ();
                setting.Show ();
            }
            */
            Connecte ();
        }
        private void Connecte () {
            try {
                string connectionString = @"server =" + server + ";port = " + port + " ; uid =" + user + ";pwd=" + password + ";database =" + database + ";charset = utf8;SslMode=none;";
                con = new MySqlConnection (connectionString);
                con.Open ();

            } catch (SqlException e) {

                MessageBox.Show (e.Message);
            }
        }

        public DataTable ReturnVal (string command) {
            DataTable r = new DataTable ();

            MySqlDataAdapter adapter = new MySqlDataAdapter (command, con);
            adapter.Fill (r);

            return r;
        }

        public void ExcuteCommand (string command) {
            //con.Open();
            com = con.CreateCommand ();
            com.CommandText = command;
            com.CommandType = CommandType.Text;

            com.ExecuteNonQuery ();
        }
        public void CloseConnection () {
            con.Close ();

        }

    }
}