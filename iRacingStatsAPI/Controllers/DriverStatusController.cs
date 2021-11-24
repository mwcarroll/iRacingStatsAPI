using iRacingStats.Core.HttpClients;
using iRacingStats.Core.Constants;
using iRacingStats.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;

namespace iRacingStats.Api.Controllers
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
        public async Task<DriverStatus> DriverStatus(string search)
        {
            Dictionary<string, string> data = new()
            {
                { "searchTerms", search }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse<DriverStatus>(URLs.DRIVER_STATUS, data);
        }
    }
}