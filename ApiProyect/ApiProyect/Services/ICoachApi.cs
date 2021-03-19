using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using ApiProyect.Models;
namespace ApiProyect.Services
{
    public interface ICoachApi
    {
        Task<Coach> GetCoach();
    }
}
