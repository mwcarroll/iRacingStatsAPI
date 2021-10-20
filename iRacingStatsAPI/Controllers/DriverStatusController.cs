using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverStatusController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public DriverStatusController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{search}")]
        public async Task<Models.DriverStatus> DriverStatus(string search)
        {

            return await _iracingHttpClient.PostRequestAndGetResponse<Models.DriverStatus>(string.Format(Constants.URLs.DRIVER_STATUS, string.Format("searchTerms={0}", search)), null);
        }
    }
}