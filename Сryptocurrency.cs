using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace Cryptocurrencies
{
    public class Assets
    {
        public List<Сryptocurrency> assets { get; set; }
        public string next { get; set; }
    }
    public class Quote
    {
        public Currency JPY { get; set; }
        public Currency NZD { get; set; }
        public Currency CAD { get; set; }
        public Currency AUD { get; set; }
        public Currency EUR { get; set; }
        public Currency GBP { get; set; }
        public Currency USD { get; set; }

    }
    public class Currency
    {
        public double price { get; set; }
        public double volume_24h { get; set; }
        public double market_cap { get; set; }
        public double fully_diluted_market_cap { get; set; }
    }
    public class Сryptocurrency
    {
        public Quote quote { get; set; }
        public string asset_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string website { get; set; }
        public string ethereum_contract_address { get; set; }
        public double price { get; set; }
        public double volume_24h { get; set; }
        public double change_1h { get; set; }
        public double change_24h { get; set; }
        public double change_7d { get; set; }
        public double total_supply { get; set; }
        public double circulating_supply { get; set; }
        public long max_supply { get; set; }
        public double market_cap { get; set; }
        public double fully_diluted_market_cap { get; set; }
        public string status { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    public class Asset
    {
        public Сryptocurrency asset { get; set; }
    }
}
