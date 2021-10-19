using EnumsNET;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace iRacingStatsAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class YearlyStatsController : ControllerBase
    {
        [HttpGet("YearlyStats/{id:int}")]
        public async Task<IEnumerable<Models.YearlyStats>> YearlyStats(int id)
        {
            return await YearlyStats(id, null, null);
        }

        [HttpGet("YearlyStats/{id:int}/{category:alpha}")]
        public async Task<IEnumerable<Models.YearlyStats>> YearlyStats(int id, string category)
        {
            return await YearlyStats(id, null, category);
        }

        [HttpGet("YearlyStats/{id:int}/{year:int:maxlength(4)}")]
        public async Task<IEnumerable<Models.YearlyStats>> YearlyStats(int id, int? year = null)
        {
            return await YearlyStats(id, year, null);
        }

        [HttpGet("YearlyStats/{id:int}/{year:int:maxlength(4)}/{category:alpha}")]
        public async Task<IEnumerable<Models.YearlyStats>> YearlyStats(int id, int? year, string category)
        {
            Client c = new();

            Dictionary<string, string> data = new()
            {
                { "custid", id.ToString() }
            };

            IEnumerable<Models.YearlyStats> yearlyStats = await c.PostRequestAndGetResponses<Models.YearlyStats>(string.Format(Constants.URLs.YEARLY_STATS, id), data);

            if (year != null) yearlyStats = yearlyStats.Where(x => x.year.Equals(year.ToString()));
            if (category != null) yearlyStats = yearlyStats.Where(x => x.category.AsString(EnumFormat.Description).Equals(HttpUtility.UrlDecode(category), StringComparison.InvariantCultureIgnoreCase));

            return yearlyStats;
        }
    }
}
