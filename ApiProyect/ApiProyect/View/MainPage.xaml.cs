using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using Xamarin.Forms;

namespace ApiProyect
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await CallApi();
        //}
        //async Task CallApi()
        //{

        //    //var nsAPI = RestService.For<ICoachApi>("http://data.nba.net");
        //    //var sugars = await nsAPI.GetCoach();
        //}
    }
}