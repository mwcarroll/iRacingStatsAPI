using iRacingStats.Core.HttpClients;
using iRacingStats.Core.Constants;
using iRacingStats.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStats.Api.Controllers.Stats
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
        public async Task<IEnumerable<CareerStats>> CareerStats(int id)
        {
            Dictionary<string, string> data = new()
            {
                { "custid", id.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponses<CareerStats>(URLs.CAREER_STATS, data);
        }
    }
}