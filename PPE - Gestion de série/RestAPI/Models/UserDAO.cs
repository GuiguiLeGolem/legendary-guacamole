using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class UserDAO
    {
        private MySqlConnection conn;
        public UserDAO()
        {
            string myConnectionString;
            myConnectionString = "server=172.19.0.18;uid=client;pwd=0550002D;database=NetNotFlix;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }


        public bool connexion(string mail, string mdp)
        {
            string requete = "select COUNT(*) from User WHERE emailUser ='" + mail +"' AND mdpUser = '"+ mdp;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int correct = Convert.ToInt32(rdr[0]);

            if (correct == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}