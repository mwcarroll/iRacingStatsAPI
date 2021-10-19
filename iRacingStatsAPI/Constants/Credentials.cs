using System;

namespace iRacingStatsAPI.Constants
{
    public class Credentials
    {
        public string USERNAME = Environment.GetEnvironmentVariable("iR_username", EnvironmentVariableTarget.User);
        public string PASSWORD = Environment.GetEnvironmentVariable("iR_password", EnvironmentVariableTarget.User);
    }
}
