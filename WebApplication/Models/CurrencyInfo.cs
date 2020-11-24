﻿namespace WebApplication.Models
{
    public class CurrencyInfo
    {
        public string ID { get; set; }

        public string NumCode { get; set; }

        public string CharCode { get; set; }

        public uint Nominal { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public decimal Previous { get; set; }
    }
}
