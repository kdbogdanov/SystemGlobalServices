using System.Linq;
using WebApplication.Services;
using WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    public class CurrenciesController : Controller
    {
        private readonly CurrenciesResponse _currencies;

        public CurrenciesController() =>
            _currencies = HttpClient.GetCurrenciesAsync().Result;

        // GET: Currencies
        [HttpGet]
        [Route("api/currencies")]
        public ActionResult GetCurrencies(int page = 1, int pageSize = 3)
        {
            var source = _currencies.Valute.Values.ToList();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize);

            return Ok(items);
        }

        // GET: Currency/
        [HttpGet]
        [Route("api/currency/{id?}")]
        public ActionResult GetCurrency(string id = "R01235")
        {
            decimal result = 0;
            foreach (var key in _currencies.Valute.Keys)
                if (_currencies.Valute[key].ID == id)
                    result = _currencies.Valute[key].Value;

            return Ok(result);
        }

    }
}
