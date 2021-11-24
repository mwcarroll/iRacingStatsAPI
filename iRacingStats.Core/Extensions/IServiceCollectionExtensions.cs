using iRacingStats.Core.HttpClients;
using iRacingStats.Core.Options;
using System.Net;

namespace iRacingStats.Core.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddiRacingStatsCore(this IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<User>(configuration.GetSection("iRacingStats.Core:User"));
            services.AddHttpClient<IRacingHttpClient>()
                .ConfigureHttpMessageHandlerBuilder(c => {
                    HttpClientHandler _ = new()
                    {
                        AllowAutoRedirect = true,
                        UseCookies = true,
                        CookieContainer = new CookieContainer()
                    };
                });
            return services;
        }
    }
}
