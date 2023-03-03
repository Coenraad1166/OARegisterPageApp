using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RegisterPageApp.Views;

namespace RegisterPageApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegisterPage());
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
