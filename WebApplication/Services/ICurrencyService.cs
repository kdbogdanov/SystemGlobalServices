using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Services
{
    public interface ICurrencyService
    {
        public Task<CurrenciesResponse> GetCurrenciesAsync();
    }
}
