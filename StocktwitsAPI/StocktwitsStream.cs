using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI {
    public class StocktwitsStream {
        private static String DEFAULT_STOCKTWITS_API = "https://api.stocktwits.com/api/2/streams/symbol/{0}.json";

        public StocktwitsResponse MakeRequest( string symbol ) {
            string urlRequest = string.Format(DEFAULT_STOCKTWITS_API, symbol);
            HttpWebRequest request = WebRequest.Create(urlRequest) as HttpWebRequest;
            using ( HttpWebResponse response = request.GetResponse() as HttpWebResponse ) {
                if ( response.StatusCode != HttpStatusCode.OK )
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                using ( StreamReader sr = new StreamReader(response.GetResponseStream(), encode) ) {
                    string json = sr.ReadToEnd();
                    StocktwitsResponse jsonResponse = JsonConvert.DeserializeObject<StocktwitsResponse>(json);
                    return jsonResponse;
                }
            }
        }

    }
}
