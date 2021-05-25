using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class Serie
    {
        private int idSerie;
        private string titreSerie;
        private string illustrationSerie;
        private string descriptionSerie;

        public Serie(int id, string titre, string illustration)
        {
            this.idSerie = id;
            this.titreSerie = titre;
            this.illustrationSerie = illustration;
            this.descriptionSerie = null;
        }

        public Serie(int idSerie, string titreSerie, string illustrationSerie, string descriptionSerie)
        {
            this.idSerie = idSerie;
            this.titreSerie = titreSerie;
            this.illustrationSerie = illustrationSerie;
            this.descriptionSerie = descriptionSerie;
        }

        public int Id { get => idSerie; set => idSerie = value; }
        public string Titre { get => titreSerie; set => titreSerie = value; }
        public string Illustration { get => illustrationSerie; set => illustrationSerie = value; }
        public string DescriptionSerie { get => descriptionSerie; set => descriptionSerie = value; }
    }
}