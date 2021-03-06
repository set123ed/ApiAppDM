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
        public ObservableCollection<Standard> _Coach { get; set; }

        //_Coach obj = new JsonObject();

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
                var coach = await apiService.GetLeague();
                await App.Current.MainPage.DisplayAlert("Coach League 2020", "There's the Coach List of 2020", "Ok");
                _Coach = new ObservableCollection<Standard>(coach.League.Standard);
                

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("No Network", "Please connect to network", "Ok");
            }

        }
    }
}

