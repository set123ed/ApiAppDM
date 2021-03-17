using System;
using System.Text.Json;
using System.Threading.Tasks;
using ApiAppDM.Models;

namespace ITeamApiService
{
    public interface ITeamApiService

        {
            Task<TeamSchedule> GetTeamScheduleInformation();
        }
}
