using iRacingStatsAPI.Options;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace iRacingStatsAPI.HttpClients
{
	public class IRacingHttpClient
	{
		private readonly ILogger<IRacingHttpClient> _logger;
		private readonly HttpClient _httpClient;
		private readonly IMemoryCache _memoryCache;
		private readonly User _user;

		public IRacingHttpClient(ILogger<IRacingHttpClient> logger, HttpClient httpClient, IMemoryCache memoryCache, IOptions<User> options)
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

		public async Task<HttpResponseMessage> PostRequest(string url, Dictionary<string, object> formData)
		{
			var lastPostDateTime = DateTime.MinValue;
			if (_memoryCache.TryGetValue("IRacingHttpClient::LastPostDateTime", out DateTime cache_last))
			{
				lastPostDateTime = cache_last;
			}

			var isLoggedIn = false;
			if (_memoryCache.TryGetValue("IRacingHttpClient::IsLoggedIn", out bool cache_isLoggedIn))
			{
				isLoggedIn = cache_isLoggedIn;
			}

            IEnumerable<string> cookies = new List<string>();
			if (_memoryCache.TryGetValue("IRacingHttpClient::Cookies", out IEnumerable<string> cached_cookies))
			{
				cookies = cached_cookies;
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
					_memoryCache.Set("IRacingHttpClient::Cookies", GetCookies(loginResponse));

					throw new HttpRequestException("Login request redirected to /failedlogin, indicationg an authentication error. If credentials are correct, check that a captcha is not required by manually visiting members.iracing.com");
				}
				else
				{
					_memoryCache.Set("IRacingHttpClient::IsLoggedIn", true);
					_memoryCache.Set("IRacingHttpClient::Cookies", GetCookies(loginResponse));
				}

				System.Threading.Thread.Sleep(Constants.Config.POST_DELAY);
			}

			StringContent content = (formData != null) ? new(JsonSerializer.Serialize(formData)) : null;

			HttpRequestMessage request = new(HttpMethod.Post, url);
			request.Headers.Add("Cookie", cookies);
			request.Content = content;

			HttpResponseMessage response = await _httpClient.SendAsync(request);

			if (response.RequestMessage.RequestUri.AbsolutePath.Contains("login")){
				_memoryCache.Set("IRacingHttpClient::IsLoggedIn", false);

				return await PostRequest(url, formData);
			}

			_memoryCache.Set("IRacingHttpClient::LastPostDateTime", DateTime.UtcNow);

			return response;
		}

		public async Task<IEnumerable<T>> PostRequestAndGetResponses<T>(string url, Dictionary<string, object> formData)
		{
			HttpResponseMessage response = await PostRequest(url, formData);
			string jsonString = await response.Content.ReadAsStringAsync();

			IEnumerable<T> serialized = JsonSerializer.Deserialize<IEnumerable<T>>(jsonString);
			return serialized;
		}
		public async Task<Type> PostRequestAndGetResponse<Type>(string url, Dictionary<string, object> formData)
		{
			HttpResponseMessage response = await PostRequest(url, formData);
			string jsonString = await response.Content.ReadAsStringAsync();

			Type serialized = JsonSerializer.Deserialize<Type>(jsonString);
			return serialized;
		}

		public async Task<string> PostRequestAndGetResponse(string url, Dictionary<string, object> formData)
		{
			HttpResponseMessage response = await PostRequest(url, formData);
			string jsonString = await response.Content.ReadAsStringAsync();
			return jsonString;
		}

		public IEnumerable<string> GetCookies(HttpResponseMessage message)
        {
			message.Headers.TryGetValues("Set-Cookie", out var cookies);

			return cookies;
        }
	}
}
