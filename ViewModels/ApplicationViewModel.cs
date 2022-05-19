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
    public class ApplicationViewModel
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

        private bool _isLoadData;

        public bool IsLoadData
        {
            get { return _isLoadData; }
            set { _isLoadData = value; }
        }

        public DelegateCommand GetButtonClicked { get; set; }

        public ApplicationViewModel()
        {
            GetButtonClicked = new DelegateCommand(GetDetails);
            GetDetails();
            GetDetailsOne();
        }
        
        private void GetDetails()
        {
            var Details = API.GetCall("assets");
            if (Details.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Cryptocurrencies = Details.Result.Content.ReadAsAsync<Assets>().Result;
                IsLoadData = true;
            }
        }
        private void GetDetailsOne()
        {
            var Details = API.GetCall("assets/BTC");
            if (Details.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Сryptocurrency = Details.Result.Content.ReadAsAsync<Asset>().Result;
                IsLoadData = true;
            }
        }
    }
}
