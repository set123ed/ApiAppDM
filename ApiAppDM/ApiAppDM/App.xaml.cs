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
            var teamService = new TeamApiService();
            var teamScheduleInfo = await teamService.GetTeamScheduleInformation();

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
