using ApiAppDM.Services;
using Xamarin.Forms;



namespace ApiAppDM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override async void OnStart()
        {
            var teamService = new TeamScheduleService();
            var teamScheduleInfo = await teamService.GetTeamsScheduleAsync();

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
