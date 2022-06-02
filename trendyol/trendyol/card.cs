using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trendyol
{
    class card
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int Count { get; set; }
        public void cardInfo()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Mehsulun kodu: " + this.ProductID + "\n");
            info.Append("Mehsulun sayi: " + this.Count + "\n");
        }
    }
}
