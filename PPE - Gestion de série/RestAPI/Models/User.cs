using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class User
    {
        private int id;
        private string pseudo;
        private string mdp;
        private string email;

        public User(int id, string pseudo, string mdp, string email)
        {
            this.id = id;
            this.pseudo = pseudo;
            this.mdp = mdp;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Email { get => email; set => email = value; }
    }
}