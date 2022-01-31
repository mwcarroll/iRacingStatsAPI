namespace iRacingStats.Core.Models.Leagues
{
    public class LeagueRace
    {
        public int practicedur { get; set; }
        public string reason { get; set; } = string.Empty;
        public string hs_mainsessionlenmins { get; set; } = string.Empty;
        public string hs_mainnumlaps { get; set; } = string.Empty;
        public int league_season_id { get; set; }
        public int warmuplength { get; set; }
        public int qualdur { get; set; }
        public int weather_temp_units { get; set; }
        public int weather_wind_dir { get; set; }
        public string hs_prequalpracticelenmins { get; set; } = string.Empty;
        public int weather_temp_value { get; set; }
        public string hs_consolfirstsessionnumlaps { get; set; } = string.Empty;
        public string hs_qualscoreschamppoints { get; set; } = string.Empty;
        public int privatesessionid { get; set; }
        public object sessionid { get; set; } = string.Empty;
        public string hs_heatnumpostoinvert { get; set; } = string.Empty;
        public string hs_heatmaxfieldsize { get; set; } = string.Empty;
        public int practicelength { get; set; }
        public string hs_is_hidden { get; set; } = string.Empty;
        public string hs_custid { get; set; } = string.Empty;
        public string hs_heatinfoname { get; set; } = string.Empty;
        public string hs_heatnumlaps { get; set; } = string.Empty;
        public int qualifylength { get; set; }
        public int weather_fog_density { get; set; }
        public string hs_consolnumpostoinvert { get; set; } = string.Empty;
        public string hs_heatinfoid { get; set; } = string.Empty;
        public string hs_mainnumpostoinvert { get; set; } = string.Empty;
        public string hs_prequalnumtomain { get; set; } = string.Empty;
        public string hs_heatnumfromeachtomain { get; set; } = string.Empty;
        public string hs_practiceisopen { get; set; } = string.Empty;
        public string hs_racestyle { get; set; } = string.Empty;
        public string hs_heatcautiontype { get; set; } = string.Empty;
        public List<Car> cars { get; set; } = new List<Car>();
        public string hs_consolscoreschamppoints { get; set; } = string.Empty;
        public int leagueid { get; set; }
        public string hs_qualopendelaysecs { get; set; } = string.Empty;
        public object launchat { get; set; } = string.Empty;
        public int rn { get; set; }
        public int racelaps { get; set; }
        public int racedur { get; set; }
        public int status { get; set; }
        public object winnersgroupid { get; set; } = string.Empty;
        public string hs_qualnumlaps { get; set; } = string.Empty;
        public string qualtype { get; set; } = string.Empty;
        public int hs_created { get; set; }
        public int trackid { get; set; }
        public int weather_type { get; set; }
        public string hs_consolfirstsessionlenmins { get; set; } = string.Empty;
        public int hasresults { get; set; }
        public int rubberlevel_race { get; set; }
        public int qualifylaps { get; set; }
        public int rubberlevel_practice { get; set; }
        public int weather_skies { get; set; }
        public int grip_compound_practice { get; set; }
        public string hs_consoldeltamaxfieldsize { get; set; } = string.Empty;
        public int weather_var_ongoing { get; set; }
        public string hs_maxentrants { get; set; } = string.Empty;
        public string hs_qualstyle { get; set; } = string.Empty;
        public int grip_compound_qualify { get; set; }
        public string hs_consolnumtoconsolation { get; set; } = string.Empty;
        public string hs_consoldeltasessionnumlaps { get; set; } = string.Empty;
        public object subsessionid { get; set; } = string.Empty;
        public int leavemarbles { get; set; }
        public int rubberlevel_qualify { get; set; }
        public string track_name { get; set; } = string.Empty;
        public string hs_description { get; set; } = string.Empty;
        public string config_name { get; set; } = string.Empty;
        public int weather_rh { get; set; }
        public string hs_imageurl { get; set; } = string.Empty;
        public int weather_var_initial { get; set; }
        public string hs_consolnumtomain { get; set; } = string.Empty;
        public int warmupdur { get; set; }
        public string hs_qualscoring { get; set; } = string.Empty;
        public int racelength { get; set; }
        public string hs_consoldeltasessionlenmins { get; set; } = string.Empty;
        public int timelimit { get; set; }
        public string hs_consolrunalways { get; set; } = string.Empty;
        public string hs_qualsessionlenmins { get; set; } = string.Empty;
        public int lonequalify { get; set; }
        public int rubberlevel_warmup { get; set; }
        public string hs_qualcautiontype { get; set; } = string.Empty;
        public string hs_premainpracticelenmins { get; set; } = string.Empty;
        public int weather_wind_speed_value { get; set; }
        public string hs_qualnumtomain { get; set; } = string.Empty;
        public string hs_heatsessionlenmins { get; set; } = string.Empty;
        public string hs_heatscoreschamppoints { get; set; } = string.Empty;
        public int grip_compound_warmup { get; set; }
        public string hs_mainmaxfieldsize { get; set; } = string.Empty;
        public int grip_compound_race { get; set; }
        public int driver_changes { get; set; }
        public string winnername { get; set; } = string.Empty;
        public int weather_wind_speed_units { get; set; }
        public string hs_consolfirstmaxfieldsize { get; set; } = string.Empty;
    }
   
}
