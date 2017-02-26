using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsAPI {
    [Serializable]
    public class StocktwitsUser {
        public int id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string avatar_url { get; set; }
        public string avatar_url_ssl { get; set; }
        public string join_date { get; set; }
        public bool official { get; set; }
        public string identity { get; set; }
    }
}
