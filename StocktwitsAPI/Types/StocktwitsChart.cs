using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    [Serializable]
    public class StocktwitsChart {
        public string thumb { get; set; }
        public string large { get; set; }
        public string original { get; set; }
        public string url { get; set; }
    }
}
