using System;
using System.Collections.Generic;
using System.Text;

namespace NetNotFlix.Classes
{
    class Saison
    {
        private int idSaison;
        private int numSaison;
        private string strSaison;
        private string sortieSaison;
        private int idSerie;

        public Saison(int idSaison, int numSaison, string sortieSaison, int idSerie)
        {
            this.idSaison = idSaison;
            this.numSaison = numSaison;
            this.sortieSaison = sortieSaison;
            this.idSerie = idSerie;
            this.StrSaison = "Saison ";
        }

        public int IdSaison { get => idSaison; set => idSaison = value; }
        public int NumSaison { get => numSaison; set => numSaison = value; }
        public string SortieSaison { get => sortieSaison; set => sortieSaison = value; }
        public int IdSerie { get => idSerie; set => idSerie = value; }
        public string StrSaison { get => strSaison; set => strSaison = value; }
    }
}
