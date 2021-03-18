using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ApiAppDM.Models;
using ApiAppDM.Services;
using ApiAppDM.ViewModels;

using Xamarin.Forms;

namespace ApiAppDM.Views
{
    public partial class TeamSchedulePage : ContentPage
    {
        public TeamSchedulePage()
        {
            InitializeComponent();
            BindingContext = new TeamScheduleViewModel(new TeamScheduleService());
            //GetCoach();
        }
        //private async void GetCoach()
        //{
        //    HttpClient client = new HttpClient();
        //    var clientResponse = await client.GetStringAsync("http://data.nba.net/data/10s/prod/v1/2020/coaches.json");

        //    var coaches = JsonSerializer.Deserialize<List<CoachesInformation>>(clientResponse);
        //    CoachListView.ItemSource = coaches;
        //}
    }

}
