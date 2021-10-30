using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers.Stats
{
    [Route("api/stats/[controller]")]
    [ApiController]
    public class CareerController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public CareerController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<Models.CareerStats>> CareerStats(int id)
        {
            Dictionary<string, string> data = new()
            {
                { "custid", id.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponses<Models.CareerStats>(Constants.URLs.CAREER_STATS, data);
        }
    }
}