using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class EpisodeDAO
    {
        private MySqlConnection conn;
        public EpisodeDAO()
        {
            string myConnectionString;
            myConnectionString = "server=172.19.0.18;uid=client;pwd=0550002D;database=NetNotFlix;";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }

        public List<Episode> getAllEpisodes(int idSaison)
        {
            List<Episode> lesEpisodes = new List<Episode>();
            string requete = "select * from Episode WHERE idSaison="+idSaison;
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Episode c = new Episode(Convert.ToInt16(rdr[0]), rdr[1].ToString(), rdr[2].ToString(), Convert.ToInt32(rdr[3]));
                lesEpisodes.Add(c);
            }
            rdr.Close();
            return lesEpisodes;
        }
    }
}