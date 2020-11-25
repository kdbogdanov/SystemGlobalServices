using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    /// <summary>
    /// Сlass for storing all information about 
    /// daily data on exchange rates of the Central Bank
    /// </summary>
    public class CurrenciesResponse
    {
        public DateTime Date { get; set; }

        public DateTime PreviousDate { get; set; }

        public string PreviousURL { get; set; }

        public DateTime Timestamp { get; set; }

        public Dictionary<string, CurrencyInfo> Valute { get; set; }

    }
}
