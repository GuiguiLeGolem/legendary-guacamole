using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class SaisonDAO
    {
        private MySqlConnection conn;
        public SaisonDAO()
        {
            string myConnectionString;
            myConnectionString = "server=localhost;uid=root;pwd=;database=NetNotFlix;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }
        public List<Saison> getSaisons(int idSerie)
        {
            List<Saison> lesSaisons = new List<Saison>();
            string requete = "select * from Saison WHERE idSerie="+idSerie+";";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int truc = Convert.ToInt32(rdr[0]);
                string trucbis = Convert.ToString(rdr[1]);

                Saison s = new Saison(Convert.ToInt32(rdr[0]), rdr[1].ToString(), Convert.ToInt32(rdr[2]), Convert.ToInt32(rdr[3])); ;
                lesSaisons.Add(s);
            }
            rdr.Close();
            return lesSaisons;
        }
    }
}