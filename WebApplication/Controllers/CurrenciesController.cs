using System.Linq;
using WebApplication.Services;
using WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [ApiController]
    public class CurrenciesController : Controller
    {
        private readonly ICurrencyService _currencyService;

        public CurrenciesController(ICurrencyService currencyService) =>
            _currencyService = currencyService;


        // GET: Currencies
        [HttpGet]
        [Route("api/currencies")]
        public async Task<ActionResult> GetCurrenciesAsync(int page = 1, int pageSize = 3)
        {
            var currencies = await _currencyService.GetCurrenciesAsync();
            var source = currencies.Valute.Values.ToList();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize);

            return Ok(items);
        }

        // GET: Currency/
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
