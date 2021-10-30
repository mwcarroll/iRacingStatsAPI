using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubsessionResultsController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public SubsessionResultsController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{subsessionId:int}/{custId:int}")]
        public async Task<string> SubsessionResults(int subsessionId, int custId)
        {
            Dictionary<string, string> data = new()
            {
                { "subsessionID", subsessionId.ToString() },
                { "custId", custId.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse(Constants.URLs.SUBSESSION_RESULTS, data);
        }
    }
}