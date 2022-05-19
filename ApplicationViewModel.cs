using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Cryptocurrencies
{
    class ApplicationViewModel
    {
        private Asset cryptocurrency;
        
        public Asset Сryptocurrency
        {
            get { return cryptocurrency; }
            set { cryptocurrency = value; }
        }
        private Assets сryptocurrencies;

        public Assets Cryptocurrencies
        {
            get { return сryptocurrencies; }
            set { сryptocurrencies = value; }
        }
       
        private Сryptocurrency selectedСryptocurrency;

        public Сryptocurrency SelectedСryptocurrency
        {
            get { return selectedСryptocurrency; }
            set
            {
                selectedСryptocurrency = value;
            }
        }

        public ApplicationViewModel()
        {
            GetDetails();
            GetDetailsOne();
        }
        
        private void GetDetails()
        {
            var Details = API.GetCall("assets");
            if (Details.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Cryptocurrencies = Details.Result.Content.ReadAsAsync<Assets>().Result;
            }
        }
        private void GetDetailsOne()
        {
            var Details = API.GetCall("assets/BTC");
            if (Details.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Сryptocurrency = Details.Result.Content.ReadAsAsync<Asset>().Result;
            }
        }
    }
}
