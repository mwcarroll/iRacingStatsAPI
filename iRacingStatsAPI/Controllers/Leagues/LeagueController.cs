using iRacingStats.Core.HttpClients;
using iRacingStats.Core.Constants;
using iRacingStats.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using iRacingStats.Core.Models.Leagues;

namespace iRacingStats.Api.Controllers.Stats
{
    [Route("api/stats/[controller]")]
    [ApiController]
    public class LeagueController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public LeagueController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet]
        public async Task<iRacingModelRowData<League>> GetLeagues()
        {
            Dictionary<string, string> data = new()
            {
                { "restrictToMember", "1" },
                { "lowerbound", "1" },
                { "upperbound", "22" }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse<iRacingModelRowData<League>>(URLs.LEAGUE_DIRECTORY, data);
        }

        [HttpGet("{id}")]
        public async Task<iRacingModelRowData<LeagueSeason>> GetSeasons(int id)
        {
            Dictionary<string, string> data = new()
            {
                { "leagueID", id.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse<iRacingModelRowData<LeagueSeason>>(URLs.LEAGUE_SEASONS, data);
        }

        [HttpGet("{id}/{season}")]
        public async Task<RowDataActual<LeagueRace>> GetSeasonSessions(int id, int season)
        {
            Dictionary<string, string> data = new()
            {
                { "leagueID", id.ToString() },
                { "leagueSeasonID", season.ToString() }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse<RowDataActual<LeagueRace>>(URLs.LEAGUE_SEASON_SESSIONS, data);
        }
    }
}