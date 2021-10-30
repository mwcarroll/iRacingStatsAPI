using iRacingStatsAPI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiveOpenPracticeController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public ActiveOpenPracticeController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{maxCount:int}/{includeEmpty:bool}")]
        public async Task<Models.iRacingModelData<Models.OpenPractice>> ActiveOpenPractice(int maxCount, bool includeEmpty)
        {
            Dictionary<string, string> data = new()
            {
                { "maxcount", maxCount.ToString() },
                { "include_empty", includeEmpty.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse<Models.iRacingModelData<Models.OpenPractice>>(Constants.URLs.ACTIVEOP_COUNT, data);
        }
    }
}