using System;
using System.Collections.Generic;
using System.Text;

namespace NetNotFlix.Classes
{
    class Episode
    {
        private int idEpisode;
        private string numEpisode;
        private string titreEpisode;
        private int idSaison;

        public Episode(int idEpisode, string numEpisode, string titreEpisode, int idSaison)
        {
            this.idEpisode = idEpisode;
            this.numEpisode = numEpisode;
            this.titreEpisode = titreEpisode;
            this.idSaison = idSaison;
        }

        public Episode(int idEpisode, string numEpisode, string titreEpisode)
        {
            this.idEpisode = idEpisode;
            this.numEpisode = numEpisode;
            this.titreEpisode = titreEpisode;
            this.idSaison = 0;
        }

        public int IdEpisode { get => idEpisode; set => idEpisode = value; }
        public string NumEpisode { get => numEpisode; set => numEpisode = value; }
        public string TitreEpisode { get => titreEpisode; set => titreEpisode = value; }
        public int IdSaison { get => idSaison; set => idSaison = value; }
    }
}
