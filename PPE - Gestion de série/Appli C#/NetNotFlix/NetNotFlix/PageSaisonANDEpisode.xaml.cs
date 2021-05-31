using NetNotFlix.classes;
using NetNotFlix.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetNotFlix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSaisonANDEpisode : ContentPage
    {
        public int idUser;

        public PageSaisonANDEpisode(Serie serie, int id)
        {
            InitializeComponent();
            idUser = id;
            OnLoad((Serie)serie);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void OnLoad(Serie serie) //fait à la main
        {
            Picker comboBoxSaison = new Picker();
            RestService rsrv = new RestService();
            comboBoxSaison.ItemsSource = await rsrv.loadAllSaison(serie.Id); //RestService.cs
            lePicker.ItemsSource = comboBoxSaison.ItemsSource;
            lePicker.SelectedIndex = 0;
            MainGrid.Children.Add(lePicker);

            //Charger les épisodes

            
        }

        private void lePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listViewEpisodes = new ListView();
            //listViewEpisodes.ItemsSource = await rsrv.loadEpisodesFromSaison((Saison)lePicker.Items[lePicker.SelectedIndex].IdSaison);
        }
    }
}