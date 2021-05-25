using System;
using System.Collections.Generic;
using System.Text;

namespace NetNotFlix.classes
{
    public class Serie
    {
        private int id;
        private string titre;
        private string illustration;
        private string description;

        //public Serie(int id, string titre, string illustration)
        //{
        //    this.Id = id;
        //    this.Titre = titre;
        //    this.Illustration = illustration;
        //    this.Description = null;
        //}

        public Serie(int idSerie, string titreSerie, string illustrationSerie, string descriptionSerie)
        {
            this.id = idSerie;
            this.titre = titreSerie;
            this.illustration = illustrationSerie;
            this.description = descriptionSerie;
        }

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Illustration { get => illustration; set => illustration = value; }
        public string Description { get => description; set => description = value; }
    }
}
