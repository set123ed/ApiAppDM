using System;
using System.Collections.Generic;
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
        }
    }
}
