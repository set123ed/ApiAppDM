using System;
using ApiProyect.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using ApiProyect.View;

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
            var coachInfo = await coachService.GetCoachList();

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
