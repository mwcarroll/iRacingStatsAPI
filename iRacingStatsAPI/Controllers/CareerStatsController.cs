using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareerStatsController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public CareerStatsController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<Models.CareerStats>> CareerStats(int id)
        {
            Dictionary<string, object> data = new()
            {
                { "custid", id }
            };

            return await _iracingHttpClient.PostRequestAndGetResponses<Models.CareerStats>(string.Format(Constants.URLs.CAREER_STATS, id), data);
        }
    }
}