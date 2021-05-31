using NetNotFlix.classes;
using NetNotFlix.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetNotFlix
{
    public partial class MainPage : ContentPage
    {
        public static ObservableCollection<Serie> lesSeries;

        public int idUser;

        public MainPage(int id)
        {
            idUser = id;
            InitializeComponent();
            lesSeries = new ObservableCollection<Serie>();
            ListViewSeries.ItemsSource = lesSeries;
            NavigationPage.SetHasNavigationBar(this, false);
            _ = ChargerLesSeriesAsync();
        }

        public async Task ChargerLesSeriesAsync()
        {
            ObservableCollection<Serie> lesS = await AppelGet();
            //Debug.WriteLine("J'en récupère " + lesS.Count);
            foreach (Serie c in lesS)
            {
                lesSeries.Add(c);
            }
        }

        public async static Task<ObservableCollection<Serie>> AppelGet()
        {
            RestService rsrv = new RestService();
            return await rsrv.loadAllSeries();
        }

        public MainPage(Serie nouvelleSerie)
        {
            InitializeComponent();
            lesSeries = new ObservableCollection<Serie>();
            ListViewSeries.ItemsSource = lesSeries;
            lesSeries.Add(nouvelleSerie);
        }

        private void ListViewSeries_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Serie laSerieSelectionne = (Serie)(sender as ListView).SelectedItem;
            PageSaisonANDEpisode nouvellePage = new PageSaisonANDEpisode(laSerieSelectionne, idUser);
            Navigation.PushAsync(nouvellePage);
        }
    }
}
