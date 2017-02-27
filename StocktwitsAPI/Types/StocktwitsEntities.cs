using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    [Serializable]
    public class StocktwitsEntities {
        public StocktwitsSentiment sentiment { get; set; }
        public StocktwitsChart chart { get; set; }
    }
}
