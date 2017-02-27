using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    public class StocktwitsSentiment {
        public StocktwitsSentimentType basic { get; set; }
    }

    public enum StocktwitsSentimentType {
        Bullish,
        Bearish
    }
}
