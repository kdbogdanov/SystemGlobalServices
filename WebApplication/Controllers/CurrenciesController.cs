using System.Linq;
using WebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    /// <summary>
    /// Controller that implements 2 api methods:
    /// GET /currencies
    /// GET /currency/ 
    /// </summary>
    [ApiController]
    public class CurrenciesController : Controller
    {
        private readonly ICurrencyService _currencyService;

        public CurrenciesController(ICurrencyService currencyService) =>
            _currencyService = currencyService;


        /// <summary>
        /// GET: /currencies
        /// Should return a list of currency rates 
        /// with the possibility of pagination.
        /// </summary>
        /// <param name="page">Current page</param>
        /// <param name="pageSize">Number of currencies per page</param>
        [HttpGet]
        [Route("api/currencies")]
        public async Task<ActionResult> GetCurrenciesAsync(int page = 1, int pageSize = 3)
        {
            var currencies = await _currencyService.GetCurrenciesAsync();
            var source = currencies.Valute.Values.ToList();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize);

            return Ok(items);
        }

        /// <summary>
        /// Get: /currency/
        /// Should return the currency rate 
        /// for the passed currency identifier.
        /// </summary>
        /// <param name="id">Currency identifier</param>
        [HttpGet]
        [Route("api/currency/{id?}")]
        public async Task<ActionResult> GetCurrencyAsync(string id = "R01235")
        {
            var currencies = await _currencyService.GetCurrenciesAsync();
            decimal result = 0;
            foreach (var key in currencies.Valute.Keys)
                if (currencies.Valute[key].ID == id)
                    result = currencies.Valute[key].Value;

            return Ok(result);
        }

    }
}
