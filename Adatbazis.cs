using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GyumolcsokGyak
{
    internal class Adatbazis
    {

        MySqlConnection conn;
        MySqlCommand sqlCommand;
        string hiba = null;

        public Adatbazis(string server = "localhost", string user = "root", string password = "", string db = "gyumolcsok")
        {

            conn = new MySqlConnection(kapcsolatString(server,user,password,db));
            if (kapcsolatNyit())
            {

                sqlCommand = conn.CreateCommand();

            }
            else
            {

                MessageBox.Show(hiba,"Hiba!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hiba = null;

            }

        }

        public List<GyumolcsAdat> getAllGyumolcs()
        {

            List<GyumolcsAdat> list = new List<GyumolcsAdat>();
            sqlCommand.CommandText = "SELECT `id`, `nev`, `egysegar`, `mennyiseg` FROM `gyumolcs` WHERE 1";
            if (kapcsolatNyit())
            {

                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        GyumolcsAdat gyumolcs = new GyumolcsAdat(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                        list.Add(gyumolcs);

                    }

                }
                kapcsolatZar();

            }
            return list;

        }



        private bool kapcsolatNyit()
        {

            //Megadott kapcsolati adatok alapján felépíti az  adatelérést
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {

                    conn.Open();

                }
            }
            catch (MySqlException ex)
            {

                hiba = ex.Message;
                return false;

            }

            return true;
        }
        
        private bool kapcsolatZar()
        {

            //Megadott kapcsolati adatok alapján felépíti az  adatelérést
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {

                    conn.Close();

                }
            }
            catch (MySqlException ex)
            {

                hiba = ex.Message;
                return false;

            }

            return true;
        }

        private string kapcsolatString(string server, string user, string password, string db)
        {
            
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server; 
            builder.UserID = user; 
            builder.Password = password; 
            builder.Database = db;
            return builder.ConnectionString;

        }
    }
}
