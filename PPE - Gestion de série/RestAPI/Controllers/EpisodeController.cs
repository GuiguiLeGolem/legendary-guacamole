using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class EpisodeController : ApiController
    {
        [HttpGet]
        public IEnumerable<Episode> GetAll(int idSaison)
        {
            EpisodeDAO dao = new EpisodeDAO();
            List<Episode> lesEpisodes = dao.getAllEpisodes(idSaison);
            return lesEpisodes.ToList();
        }
    }
}
