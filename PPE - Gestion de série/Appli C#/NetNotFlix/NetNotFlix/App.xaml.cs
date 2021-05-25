using NetNotFlix.classes;
using NetNotFlix.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetNotFlix
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
        {
            ObservableCollection<Serie> lesS = await AppelGet();
            Debug.WriteLine("J'en récupère " + lesS.Count);
            foreach (Serie c in lesS)
            {
                NetNotFlix.MainPage.lesSeries.Add(c);
            }
        }

        protected override void OnSleep()
        { 
        }

        protected override void OnResume()
        {
        }

        public async static Task<ObservableCollection<Serie>> AppelGet()
        {
            RestService rsrv = new RestService();
            return await rsrv.loadAllSeries();
        }
    }
}
