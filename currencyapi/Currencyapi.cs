using System;
using System.Data.SqlTypes;
using ipbase.Helpers;

namespace currencyapi
{
    public class Currencyapi
    {
        private string ApiKey { get; }

        public Currencyapi()
        {
        }

        public Currencyapi(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string Status()
        {
            return RequestHelper.Status(ApiKey);
        }

        public string Currencies(string currencies = "")
        {
            return RequestHelper.Currencies(ApiKey, currencies);
        }

        public string Latest(string baseCurrency = "USD", string currencies = "")
        {
            return RequestHelper.Latest(ApiKey, baseCurrency, currencies);
        }

        public string Historical(string data, string baseCurrency = "USD", string currencies = "")
        {
            return RequestHelper.Historical(ApiKey, data, baseCurrency, currencies);
        }

        public string Range(string datetimeStart, string datetimeEnd, string accuracy = "day", string baseCurrency = "USD", string currencies = "")
        {
            return RequestHelper.Range(ApiKey, datetimeStart, datetimeEnd, accuracy, baseCurrency, currencies);
        }

        public string Convert(string value, string date, string baseCurrency = "USD", string currencies = "")
        {
            return RequestHelper.Convert(ApiKey, value, date, baseCurrency, currencies);
        }
    }
}

