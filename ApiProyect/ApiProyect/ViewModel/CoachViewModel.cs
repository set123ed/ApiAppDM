using System;
using ApiProyect.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ApiProyect.Services;
using System.Windows.Input;
using Xamarin.Forms;
using static ApiProyect.Models.Coach;
using System.Collections.Generic;

namespace ApiProyect.ViewModel
{
    //public class CoachViewModel : INotifyPropertyChanged
    //{
    //    public ObservableCollection<Standard> _Coach { get; set; }

    //    public CoachApi apiService = new CoachApi();

    //    public ICommand AddCommand { get; set; }

    //    public CoachViewModel()
    //    {
    //        AddCommand = new Command(GetCoachData);
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public async void GetCoachData()
    //    {
    //        _Coach = new ObservableCollection<Standard>((IEnumerable<Standard>)await apiService.GetCoachList());
    //    }
    //}
}