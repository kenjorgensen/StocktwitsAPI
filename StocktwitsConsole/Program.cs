using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktwitsConsole {
    class Program {
        static void Main( string[] args ) {
            StocktwitsAPI.StocktwitsStream stream = new StocktwitsAPI.StocktwitsStream();

            var request = stream.MakeRequest("AMD");
        }
    }
}
