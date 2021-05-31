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
            myConnectionString = "server=localhost;uid=root;pwd=;database=NetNotFlix;";
            conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }

        public int connexion(string mail, string mdp)
        {
            string requete = "select COUNT(*), idUser from User WHERE emailUser =\"" + mail + "\" AND mdpUser = \"" + mdp + "\"";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int correct = 0;
            int id = 0;
            while (rdr.Read())
            {
                correct = Convert.ToInt32(rdr[0]);
                id = Convert.ToInt32(rdr[1]);

            }
            rdr.Close();

            if (correct == 1 && id != 0)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }

        public List<int> listeEpVue(int lIdUser, int lIdSaison)
        {
            List<int> listeEp = new List<int>();
            string requete = "SELECT visualisation.idEpisode FROM visualisation " +
                "INNER JOIN episode ON visualisation.idEpisode = episode.idEpisode " +
                "INNER JOIN saison ON episode.idSaison = saison.idSaison " +
                "WHERE visualisation.idUser= " + lIdUser + " AND saison.idSaison=" + lIdSaison + ";";
            MySqlCommand cmd = new MySqlCommand(requete, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                listeEp.Add(Convert.ToInt32(rdr[0]));
            }
            rdr.Close();
            return listeEp;
        }
    }
}