using System;
using ApiProyect.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ApiProyect.Services;
using System.Windows.Input;
using Xamarin.Forms;
using static ApiProyect.Models.Coach;
using System.Collections.Generic;
using Xamarin.Essentials;
using System.Linq;

namespace ApiProyect.ViewModel
{
    public class CoachViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<JsonObject> _Coach { get; set; }

        JsonObject obj = new JsonObject();

        public CoachApi apiService = new CoachApi();

        public ICommand AddCommand { get; set; }

        public CoachViewModel()
        {
            AddCommand = new Command(GetCoachData);
        }
        public event PropertyChangedEventHandler PropertyChanged;


        public async void GetCoachData()

        {

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                
                obj = await apiService.GetLeague();
                League league = obj.League.FirstOrDefault();
                Standard standard = league.Standard.FirstOrDefault();

                await App.Current.MainPage.DisplayAlert("Best Coach of 2020", $"{standard.firstName} {standard.lastName}", "Ok");


            }
            else
            {
                await App.Current.MainPage.DisplayAlert("No Network", "Please connect to network", "Ok");
            }

        }
    }
}

