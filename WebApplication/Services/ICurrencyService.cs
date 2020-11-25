using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Services
{
    /// <summary>
    /// Interface responsible for receiving daily data 
    /// on the exchange rates of the Central Bank
    /// </summary>
    public interface ICurrencyService
    {
        /// <summary>
        /// Asynchronous method for making a get request 
        /// for daily exchange rate data
        /// </summary>
        Task<CurrenciesResponse> GetCurrenciesAsync();
    }
}
