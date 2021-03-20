using System;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
namespace ApiProyect.Services
{
    public interface IRefitApi
    {
        [Get("/data/10s/prod/v1/{year}/coaches.json%22%22")]
        Task<HttpResponseMessage> GetCoachList(string year);
    }
}
