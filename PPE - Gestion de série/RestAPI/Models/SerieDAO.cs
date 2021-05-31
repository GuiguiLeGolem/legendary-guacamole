using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class SerieDAO
    {
        private MySqlConnection conn;

        public SerieDAO()
        {
            string myConnectionString;
            myConnectionString = "server=localhost;uid=root;pwd=;database=NetNotFlix;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }

        public List<Serie> getAllSeries()
        {
            List<Serie> lesSeries = new List<Serie>();
            string requete = "select * from Serie";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Serie c = new Serie(Convert.ToInt16(rdr[0]), rdr[1].ToString(),rdr[2].ToString(),rdr[3].ToString());
                lesSeries.Add(c);
            }
            rdr.Close();
            return lesSeries;
        }

        public void delSerie(int idSerie)
        {
            string requete = "DELETE FROM serie WHERE idSerie="+idSerie;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            cmd.ExecuteNonQuery();
        }
    }
}