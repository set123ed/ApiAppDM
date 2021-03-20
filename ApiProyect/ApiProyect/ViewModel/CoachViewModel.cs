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
        public ObservableCollection<League> _Coach { get; set; }

        public CoachApi apiService = new CoachApi();

        public ICommand AddCommand { get; set; }

        public CoachViewModel()
        {
            AddCommand = new Command(GetCoachData);
        }
        public event PropertyChangedEventHandler PropertyChanged;


        public async void GetCoachData()

        {
            List<Standard> itemCount = new List<Standard>();
            

             App.Current.MainPage.DisplayAlert("Coach list", "Coach List of 2020 ", "Ok");
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {

                var coach = await apiService.GetCoachList();
                if (coach.GetType().Name == "Coach")
                {
                    //List<Coach> CoachList = coach.League.<Standard>.where(coach => player.IsActive == true).ToList();
                    _Coach = new ObservableCollection<League>();
                }
            }
            else
            {
                App.Current.MainPage.DisplayAlert("No Network", "Please connect to network", "Ok");
            }

        }
    }
}

