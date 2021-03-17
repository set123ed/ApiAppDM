using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using ApiAppDM.Models;
using ApiAppDM.Services;

namespace ApiAppDM.ViewModels
{
    public class TeamScheduleViewModel 
    {
        public ObservableCollection<TeamSchedule> TeamInfo { get; set; }
        private ITeamScheduleService _teamScheduleService;
        public TeamScheduleViewModel(Services.TeamScheduleService teamScheduleService)
        {
            _teamScheduleService = teamScheduleService;
            GetInfoScheduleAsync();
        }

        private async void  GetInfoScheduleAsync()
        {

           
            TeamSchedule scheduleinfo = new TeamSchedule();
            scheduleinfo = await TeamScheduleService.GetTeamsScheduleAsync();

        }
    }
}
