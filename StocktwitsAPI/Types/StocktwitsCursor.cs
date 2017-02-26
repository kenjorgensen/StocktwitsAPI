using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI {
    [Serializable]
    public class StocktwitsCursor {
        public bool more { get; set; }
        public int since { get; set; }
        public int max { get; set; }
    }
}
