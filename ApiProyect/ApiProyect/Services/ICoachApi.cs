using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using ApiProyect.Models;
namespace ApiProyect.Services
{
    public interface ICoachApi
    {
        //[Get("/data/10s/prod/v1/2020/coaches.json")]
        //Task<Coach> GetCoach();

        Task<Coach> GetCoach();
    }
}
