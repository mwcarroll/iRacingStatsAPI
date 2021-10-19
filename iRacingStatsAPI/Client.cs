using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace iRacingStatsAPI
{
    public class Client
    {
        private HttpClient client;
        private bool isLoggedIn = false;
        private DateTime lastPostDateTime;

        public Client()
        {
            this.client = new();
        }

        public async Task<HttpResponseMessage> Login(string username, string password)
        {
            Dictionary<string, string> formData = new(){
                {"username", username},
                {"password", password},
                {"utcoffset", (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).TotalMinutes / 60).ToString()},
                {"todaysdate",""}
            };

            FormUrlEncodedContent content = new(formData);
            return await this.client.PostAsync(Constants.URLs.LOGIN2, content);
        }

        public async Task<HttpResponseMessage> PostRequest(string url, Dictionary<string, string> formData)
        {
            // avoid (hopefully) being rate limited
            if(lastPostDateTime.AddMilliseconds(Constants.Config.POST_DELAY) < DateTime.Now)
            {
                System.Threading.Thread.Sleep(Constants.Config.POST_DELAY);
            }

            if (!this.isLoggedIn)
            {
                HttpResponseMessage loginResponse = await this.Login(
                    Environment.GetEnvironmentVariable("iR_username", EnvironmentVariableTarget.User),
                    Environment.GetEnvironmentVariable("iR_password", EnvironmentVariableTarget.User)
                );

                if (loginResponse.RequestMessage.RequestUri.AbsolutePath.Contains("failedlogin"))
                {
                    this.isLoggedIn = false;
                    throw new HttpRequestException("Login request redirected to /failedlogin, indicationg an authentication error. If credentials are correct, check that a captcha is not required by manually visiting members.iracing.com");
                }
                else
                {
                    this.isLoggedIn = true;
                }

                System.Threading.Thread.Sleep(Constants.Config.POST_DELAY);
            }

            FormUrlEncodedContent content = new(formData);
            HttpResponseMessage response = await this.client.PostAsync(url, content);

            this.lastPostDateTime = DateTime.Now;

            return response;
        }

        public async Task<IEnumerable<T>> PostRequestAndGetResponses<T>(string url, Dictionary<string, string> formData)
        {
            HttpResponseMessage response = await this.PostRequest(url, formData);
            string jsonString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<T>>(jsonString);
        }
    }
}
