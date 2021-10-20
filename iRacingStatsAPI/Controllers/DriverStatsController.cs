using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers
{
    [Obsolete("Calling this endpoint externally appears to have been deprecated.")]
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
            Dictionary<string, object> data = new()
            {
                { "search", search }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse(Constants.URLs.DRIVER_STATS, data);
        }
    }
}