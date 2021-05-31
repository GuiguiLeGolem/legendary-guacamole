using NetNotFlix.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetNotFlix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInUser : ContentPage
    {
        public LogInUser()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Connexion(object sender, EventArgs e)
        {
            RestService rsrv = new RestService();
            int idUser = await rsrv.Connexion(emailUser.Text, mdpUser.Text);
            MainPage mainPage = new MainPage(idUser);
            //Debug.WriteLine(idUser);
            await Navigation.PushAsync(mainPage);
        }
    }
}