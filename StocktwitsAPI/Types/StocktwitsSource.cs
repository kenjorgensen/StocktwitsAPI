using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    [Serializable]
    public class StocktwitsSource {
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}
