using iRacingStats.Core.HttpClients;
using iRacingStats.Core.Constants;
using iRacingStats.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using EnumsNET;

namespace iRacingStats.Api.Controllers.Stats
{
    [Route("api/stats/[controller]")]
    [ApiController]
    public class YearlyController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public YearlyController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<YearlyStats>> YearlyStats(int id)
        {
            return await YearlyStats(id, null, null);
        }

        [HttpGet("{id:int}/{category:alpha}")]
        public async Task<IEnumerable<YearlyStats>> YearlyStats(int id, string category)
        {
            return await YearlyStats(id, null, category);
        }

        [HttpGet("{id:int}/{year:int:maxlength(4)}")]
        public async Task<IEnumerable<YearlyStats>> YearlyStats(int id, int? year = null)
        {
            return await YearlyStats(id, year, null);
        }

        [HttpGet("{id:int}/{year:int:maxlength(4)}/{category:regex(^(dirt )?((road)|(oval))$)}")]
        public async Task<IEnumerable<YearlyStats>> YearlyStats(int id, int? year, string category)
        {
            Dictionary<string, string> data = new()
            {
                { "custid", id.ToString() }
            };

            IEnumerable<YearlyStats> yearlyStats = await _iracingHttpClient.PostRequestAndGetResponses<YearlyStats>(string.Format(URLs.YEARLY_STATS, id), data);

            if (year != null) yearlyStats = yearlyStats.Where(x => x.Year.Equals(year.ToString()));
            if (category != null) yearlyStats = yearlyStats.Where(x => x.Category.AsString(EnumFormat.Description).Equals(HttpUtility.UrlDecode(category), StringComparison.InvariantCultureIgnoreCase));

            return yearlyStats;
        }
    }
}
