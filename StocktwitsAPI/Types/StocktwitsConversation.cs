using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    [Serializable]
    public class StocktwitsConversation {
        public int? parent_message_id { get; set; }
        public int? in_reply_to_message_id { get; set; }
        public bool parent { get; set; }
        public int replies { get; set; }
    }
}
