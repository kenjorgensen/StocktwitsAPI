using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    public class StocktwitsResponse {
        public StocktwitsResponseCode response { get; set; }
        public StocktwitsSymbol symbol { get; set; }
        public List<StocktwitsMessage> messages { get; set; }
    }
}
