using System;
using System.Threading.Tasks;
using ApiAppDM.Models;

namespace ApiAppDM.Services
{
    public interface ITeamScheduleService
    {
        Task<CoachesInformation> GetCoachesAsyn();
    }
}
