using EnumsNET;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace iRacingStatsAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        // GET: api/CareerStats/386110
        [HttpGet("CareerStats/{id:int}")]
        public async Task<IEnumerable<Models.CareerStats>> CareerStats(int id)
        {
            Client c = new();

            Dictionary<string, string> data = new()
            {
                {"custid", id.ToString()}
            };

            HttpResponseMessage response = await c.PostRequest(string.Format(Constants.URLs.CAREER_STATS, id), data);

            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<Models.CareerStats>>(responseBody);
        }

        // GET: api/YearlyStats/386110/2021
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

            HttpResponseMessage response = await c.PostRequest(string.Format(Constants.URLs.YEARLY_STATS, id), data);

            string responseBody = await response.Content.ReadAsStringAsync();

            IEnumerable<Models.YearlyStats> yearlyStats = JsonConvert.DeserializeObject<IEnumerable<Models.YearlyStats>>(responseBody);
            
            if (year != null) yearlyStats = yearlyStats.Where(x => x.year.Equals(year.ToString()));
            if (category != null) yearlyStats = yearlyStats.Where(x => x.category.AsString(EnumFormat.Description).Equals(HttpUtility.UrlDecode(category), StringComparison.InvariantCultureIgnoreCase));

            return yearlyStats;
        }

        [HttpGet("test")]
        public string Test()
        {
            return "test";
        }
    }
}
