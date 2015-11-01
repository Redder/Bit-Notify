using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace BitNotify
{
    class Btc
    {
        private string _currency;
        public Btc(string money = "USD")
        {
            switch (money)
            {
                case "USD":
                    _currency = "USD";
                    break;
                case "ISK":
                    _currency = "ISK";
                    break;
                case "HKD":
                    _currency = "HKD";
                    break;
                case "TWD":
                    _currency = "TWD";
                    break;
                case "CHF":
                    _currency = "CHF";
                    break;
                case "EUR":
                    _currency = "EUR";
                    break;

            }
            //First Check if Input is Correct
            _currency = money;
        }
        public string Currency {
            get { return _currency; }
            }
        public string GetCurrentValue()
        {
            WebRequest request = WebRequest.Create("https://blockchain.info/ticker");
            request.Proxy = null;
            //request.ContentType = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    dynamic responseFromServer = reader.ReadToEnd();
                    var obj = Newtonsoft.Json.Linq.JObject.Parse(responseFromServer);
                    string valueReturned = obj[_currency]["last"];
                    StringBuilder sb = new StringBuilder();
                    sb.Append(obj[_currency]["symbol"]);
                    sb.Append(obj[_currency]["last"]);
                    return sb.ToString();
                }

            }
            catch (Exception)
            {

                throw;
            } 
        }
    }
}
