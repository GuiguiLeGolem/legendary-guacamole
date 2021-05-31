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
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new LogInUser());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        { 
        }

        protected override void OnResume()
        {
        }
    }
}
