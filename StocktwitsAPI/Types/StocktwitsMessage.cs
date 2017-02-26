using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI {
    [Serializable]
    public class StocktwitsMessage {
        public int id { get; set; }
        public string body { get; set; }
        public DateTime created_at { get; set; }
        public StocktwitsUser user { get; set; }
        public StocktwitsSource source { get; set; }
        public List<StocktwitsSymbol> symbols { get; set; }
        public StocktwitsReshares reshares { get; set; }
        public StocktwitsEntities entities { get; set; }
        public List<StocktwitsLinkSource> links { get; set; }
        public StocktwitsLike likes { get; set; }
        public List<string> mentioned_users { get; set; }
        public StocktwitsConversation conversation { get; set; }
        public StocktwitsReshareMessage reshare_message { get; set; }
    }
}
