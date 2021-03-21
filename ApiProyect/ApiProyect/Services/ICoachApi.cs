using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using ApiProyect.Models;
using static ApiProyect.Models.Coach;

namespace ApiProyect.Services
{
    public interface ICoachApi
    {
        Task<_Coach> GetLeague();
    }
}
