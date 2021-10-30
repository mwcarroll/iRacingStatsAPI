using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers.Stats
{
    [Route("api/stats/[controller]")]
    [ApiController]
    public class LastRaceController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public LastRaceController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<Models.LastRaceStats>> CareerStats(int id)
        {
            Dictionary<string, string> data = new()
            {
                { "custid", id.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponses<Models.LastRaceStats>(Constants.URLs.LASTRACE_STATS, data);
        }
    }
}