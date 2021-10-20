using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverStatsController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public DriverStatsController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{search}")]
        public async Task<string> DriverStats(string search)
        {
            Dictionary<string, string> data = new()
            {
                { "search", search },
                { "category", "2" },
                { "sort", "irating" },
                { "order", "desc" },
                { "active", "1" },
                { "result_num_low", "1" },
                { "result_num_high", "25" }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse(Constants.URLs.DRIVER_STATS, data);
        }
    }
}