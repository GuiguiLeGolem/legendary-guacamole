using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class UserController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage connexion(string mail, string mdp)
        {
            UserDAO dao = new UserDAO();
            bool cbon = dao.connexion(mail,mdp);
            return Request.CreateResponse(HttpStatusCode.Created,cbon);
        }
    }
}
