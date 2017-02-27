using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    [Serializable]
    public class StocktwitsLink {
        public string title { get; set; }
        public string url { get; set; }
        public string shortened_url { get; set; }
        public string shortened_expanded_url { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public DateTime created_at { get; set; }
        public string video_url { get; set; }
        public StocktwitsLinkSource source { get; set; }
    }
}
