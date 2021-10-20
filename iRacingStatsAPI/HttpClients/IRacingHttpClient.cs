using iRacingStatsAPI.Options;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace iRacingStatsAPI.HttpClients
{
    public class IRacingHttpClient
    {
        private readonly ILogger<IRacingHttpClient> _logger;
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;
        private readonly User _user;

        public IRacingHttpClient(
            ILogger<IRacingHttpClient> logger,
            HttpClient httpClient,
            IMemoryCache memoryCache,
            IOptions<User> options
            )
        {
            _logger = logger;
            _httpClient = httpClient;
            _memoryCache = memoryCache;
            _user = options.Value;
        }

        public async Task<HttpResponseMessage> Login(string username, string password)
        {
            Dictionary<string, string> formData = new()
            {
                { "username", username },
                { "password", password },
                { "utcoffset", (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).TotalMinutes / 60).ToString() },
                { "todaysdate", "" }
            };

            FormUrlEncodedContent content = new(formData);
            return await _httpClient.PostAsync(Constants.URLs.LOGIN2, content);
        }

        public async Task<HttpResponseMessage> PostRequest(string url, Dictionary<string, string> formData)
        {
            var lastPostDateTime = DateTime.MinValue;
            if (_memoryCache.TryGetValue("IRacingHttpClient::LastPostDateTime", out DateTime last))
            {
                lastPostDateTime = last;
            }

            var isLoggedIn = false;
            if (_memoryCache.TryGetValue("IRacingHttpClient::IsLoggedIn", out bool loggedIn))
            {
                isLoggedIn = loggedIn;
            }

            // avoid (hopefully) being rate limited
            if (lastPostDateTime.AddMilliseconds(Constants.Config.POST_DELAY) < DateTime.UtcNow)
            {
                System.Threading.Thread.Sleep(Constants.Config.POST_DELAY);
            }

            if (!isLoggedIn)
            {
                HttpResponseMessage loginResponse = await Login(_user.Username, _user.Password);

                if (loginResponse.RequestMessage.RequestUri.AbsolutePath.Contains("failedlogin"))
                {
                    _memoryCache.Set("IRacingHttpClient::IsLoggedIn", false);
                    throw new HttpRequestException("Login request redirected to /failedlogin, indicationg an authentication error. If credentials are correct, check that a captcha is not required by manually visiting members.iracing.com");
                }
                else
                {
                    _memoryCache.Set("IRacingHttpClient::IsLoggedIn", true);
                }

                System.Threading.Thread.Sleep(Constants.Config.POST_DELAY);
            }

            FormUrlEncodedContent content = new(formData);
            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            _memoryCache.Set("IRacingHttpClient::LastPostDateTime", DateTime.UtcNow);

            return response;
        }

        public async Task<IEnumerable<T>> PostRequestAndGetResponses<T>(string url, Dictionary<string, string> formData)
        {
            HttpResponseMessage response = await PostRequest(url, formData);
            string jsonString = await response.Content.ReadAsStringAsync();

            IEnumerable<T> serialized = JsonSerializer.Deserialize<IEnumerable<T>>(jsonString);
            return serialized;
        }
        public async Task<Type> PostRequestAndGetResponse<Type>(string url, Dictionary<string, string> formData)
        {
            HttpResponseMessage response = await PostRequest(url, formData);
            string jsonString = await response.Content.ReadAsStringAsync();

            Type serialized = JsonSerializer.Deserialize<Type>(jsonString);
            return serialized;
        }

        public async Task<string> PostRequestAndGetResponse(string url, Dictionary<string, string> formData)
        {
            HttpResponseMessage response = await PostRequest(url, formData);
            string jsonString = await response.Content.ReadAsStringAsync();
            return jsonString;
        }
    }
}
