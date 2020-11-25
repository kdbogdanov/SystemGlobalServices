using WebApplication.Models;
using System.Configuration;
using System.Threading.Tasks;
using Flurl.Http;

namespace WebApplication.Services
{
    /// <summary>
    /// Interface implementation
    /// </summary>
    public class CurrencyService : ICurrencyService
    {
        /// <summary>
        /// Asynchronous method for making a get request 
        /// for daily exchange rate data
        /// </summary>
        public async Task<CurrenciesResponse> GetCurrenciesAsync()
        {
            var response = await ConfigurationManager.AppSettings.Get("Url")
                .GetJsonAsync<CurrenciesResponse>();
            return response;
        }
    }
}
