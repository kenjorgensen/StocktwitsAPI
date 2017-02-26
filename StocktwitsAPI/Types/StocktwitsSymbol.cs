using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI {
    [Serializable]
    public class StocktwitsSymbol {
        public int id { get; set; }
        public string symbol { get; set; }
        public string title { get; set; }
        public bool is_following { get; set; }
    }
}
