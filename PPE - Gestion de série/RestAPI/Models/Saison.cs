using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class Saison
    {
        private int idSaison;
        private string numSaison;
        private int sortieSaison;
        private int idSerie;

        public Saison(int idSaison, string numSaison, int sortieSaison, int idSerie)
        {
            this.idSaison = idSaison;
            this.numSaison = numSaison;
            this.sortieSaison = sortieSaison;
            this.idSerie = idSerie;
        }

        public int IdSaison { get => idSaison; set => idSaison = value; }
        public string NumSaison { get => numSaison; set => numSaison = value; }
        public int SortieSaison { get => sortieSaison; set => sortieSaison = value; }
        public int IdSerie { get => idSerie; set => idSerie = value; }
    }
}