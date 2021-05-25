using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class SaisonController : ApiController
    {
        [HttpGet]
        public IEnumerable<Saison> GetAll(int id)
        {
            SaisonDAO dao = new SaisonDAO();
            List<Saison> lesSaisons = dao.getSaisons(id);
            return lesSaisons.ToList();
        }
    }
}
