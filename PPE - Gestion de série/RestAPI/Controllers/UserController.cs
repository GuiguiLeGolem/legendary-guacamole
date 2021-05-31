using Newtonsoft.Json.Linq;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace RestAPI.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IEnumerable<int> GetEpVue(int IdUser, int IdSaison)
        {
            UserDAO dao = new UserDAO();
            List<int> lesEpisodesVue = dao.listeEpVue(IdUser, IdSaison);
            return lesEpisodesVue.ToList();
        }

        [HttpPost]
        public HttpResponseMessage connexion([FromBody] JObject stuff)
        {
            UserDAO dao = new UserDAO();
            var mail = stuff["mail"].ToObject<string>();
            var mdp = stuff["mdp"].ToObject<string>();
            int cbon = dao.connexion(mail, mdp);
            return Request.CreateResponse(HttpStatusCode.Created,cbon);
        }
    }
}
