using WebApplication.Models;
using System.Configuration;
using System.Threading.Tasks;
using Flurl.Http;

namespace WebApplication.Services
{
    public class HttpClient
    {
        public static async Task<CurrenciesResponse> GetCurrenciesAsync()
        {
            var response = await ConfigurationManager.AppSettings.Get("Url")
                .GetJsonAsync<CurrenciesResponse>();
            return response;
        }
    }
}
