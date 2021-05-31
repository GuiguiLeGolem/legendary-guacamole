using NetNotFlix.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetNotFlix.Classes
{
    class RestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<int> Connexion(string mail, string mdp)
        {
            string RestUrl = "http://192.168.43.52:8088/api/User/";
            var uri = new Uri(string.Format(RestUrl, string.Empty));

            Dictionary<string, string> dico = new Dictionary<string, string>();

            dico.Add("mail", mail);
            dico.Add("mdp", mdp);

            var json = JsonConvert.SerializeObject(dico);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await client.PostAsync(uri, content);

            if (response.IsSuccessStatusCode)
            {
                return Convert.ToInt16(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return 0;
            }
        }

        public async Task<ObservableCollection<Serie>> loadAllSeries()
        {
            string RestUrl = "http://192.168.43.52:8088/api/Serie/";
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            ObservableCollection<Serie> items = new ObservableCollection<Serie>();
            try
            {
                var donnee = client.GetAsync(uri);
                HttpResponseMessage response = await donnee;
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<ObservableCollection<Serie>>(content);
                    //Debug.WriteLine("On en a " + items.Count);
                    //Debug.WriteLine("Voici la Série de l'Iron Fist : son id = " + items[1].Id + " / son titre = " + items[1].Titre + " / son illustration = " + items[1].Illustration + " / sa description = " + items[1].Description);
                    return items;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<ObservableCollection<Saison>> loadAllSaison(int idSerie)
        {
            string RestUrl = "http://192.168.43.52:8088/api/Saison?id=" + idSerie;
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            ObservableCollection<Saison> items = new ObservableCollection<Saison>();
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    //Debug.WriteLine("Avant le crash");
                    items = JsonConvert.DeserializeObject<ObservableCollection<Saison>>(content);
                    //Debug.WriteLine("On en a " + items.Count);
                    //Debug.WriteLine("Voici la Saison 1 : son id = " + items[0].IdSaison + " / son numéro de série (saison 1, saison 2, etc...) = " + items[0].NumSaison + " / son année de sortie = " + items[0].SortieSaison);
                    return items;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<ObservableCollection<Episode>> loadEpisodesFromSaison(int idSaison)
        {
            string RestUrl = "http://192.168.43.52:8088/api/Episode?idSaison=" + idSaison;
            var uri = new Uri(string.Format(RestUrl, string.Empty));
            ObservableCollection<Episode> items = new ObservableCollection<Episode>();
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<ObservableCollection<Episode>>(content);
                    return items;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }
    }
}
