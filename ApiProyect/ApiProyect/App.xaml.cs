using System;
using ApiProyect.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiProyect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected async override void OnStart()
        {
            var coachService = new CoachApi();
            var coachInfo = await coachService.GetCoach();

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
