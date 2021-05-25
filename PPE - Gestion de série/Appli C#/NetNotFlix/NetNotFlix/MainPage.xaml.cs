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

        public MainPage()
        {
            InitializeComponent();
            lesSeries = new ObservableCollection<Serie>();
            ListViewSeries.ItemsSource = lesSeries;
            NavigationPage.SetHasNavigationBar(this, false);
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
            PageSaisonANDEpisode nouvellePage = new PageSaisonANDEpisode(laSerieSelectionne);
            Navigation.PushAsync(nouvellePage);
        }
    }
}
