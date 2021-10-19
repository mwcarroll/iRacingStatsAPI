using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStatsAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class CareerStatsController : ControllerBase
    {
        [HttpGet("CareerStats/{id:int}")]
        public async Task<IEnumerable<Models.CareerStats>> CareerStats(int id)
        {
            Client c = new();

            Dictionary<string, string> data = new()
            {
                { "custid", id.ToString() }
            };

            return await c.PostRequestAndGetResponses<Models.CareerStats>(string.Format(Constants.URLs.CAREER_STATS, id), data);
        }
    }
}