using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trendyol
{
    public class Payment : Order
    {
        public Payment()
        {

        }
        public int PaymentId { get; set; }
        public string CardType { get; set; }
        public string CardDate { get; set; }
        public int CardCVV { get; set; }
        public void AboutPayment()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Kart novu: " + this.CardType + "\n");
            info.Append("Nomresi: " + this.card + "\n");
            info.Append("Muddeti: " + this.CardDate + "\n");
            info.Append("Kodu: " + this.CardCVV + "\n");
            Console.WriteLine(info);
        }
    }
}
