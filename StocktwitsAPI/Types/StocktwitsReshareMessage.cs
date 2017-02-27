using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    [Serializable]
    public class StocktwitsReshareMessage {
        public int reshared_count { get; set; }
        public bool reshared_deleted { get; set; }
        public bool reshared_user_deleted { get; set; }
        public bool parent_reshared_deleted { get; set; }
        public StocktwitsMessage message { get; set; }

    }
}
