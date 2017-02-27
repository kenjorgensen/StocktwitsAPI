using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI.Types {
    [Serializable]
    public class StocktwitsReshares {
        public int reshared_count { get; set; }
        public List<int> user_ids { get; set; }
    }
}
