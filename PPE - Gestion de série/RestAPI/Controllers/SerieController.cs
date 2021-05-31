using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class SerieController : ApiController
    {
        [HttpPost]
        public bool AddContact()
        {
            return true;
        }
        [HttpGet]
        public IEnumerable<Serie> GetAll()
        {
            SerieDAO dao = new SerieDAO();
            List<Serie> lesSeries = dao.getAllSeries();
            return lesSeries.ToList();
        }

        [HttpDelete]
        public string DeleteSerie(int id)
        {
            SerieDAO dao = new SerieDAO();
            dao.delSerie(id);
            return "Serie supprimé id " + id;
        }
        [HttpPut]
        public string UpdateContact(string Name, String Id)
        {
            return "Mise à jour du contact avec le nom " + Name + " and Id " + Id;
        }

    }
}
