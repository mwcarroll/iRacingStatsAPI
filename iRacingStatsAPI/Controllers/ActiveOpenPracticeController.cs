using iRacingStats.Core.HttpClients;
using iRacingStats.Core.Constants;
using iRacingStats.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStats.Api.Controllers
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
        public async Task<iRacingModelData<OpenPractice>> ActiveOpenPractice(int maxCount, bool includeEmpty)
        {
            Dictionary<string, string> data = new()
            {
                { "maxcount", maxCount.ToString() },
                { "include_empty", includeEmpty.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse<iRacingModelData<OpenPractice>>(URLs.ACTIVEOP_COUNT, data);
        }
    }
}