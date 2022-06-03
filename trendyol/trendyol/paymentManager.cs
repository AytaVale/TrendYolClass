using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trendyol
{
    class paymentManager
    {
        public void managePayment()
        {
            Payment payment1 = new Payment();
            Console.Write("Kartin novunu sechin: ");
            payment1.CardType = Console.ReadLine();
            Console.Write("Kartin nomresini daxil edin: ");
            payment1.card = Console.ReadLine();
            Console.WriteLine("Kartin bitme tarixini qeyd edin: (dd/yy formasinda) ");
            payment1.CardDate = Console.ReadLine();
            Console.Write("Kartin CVV kodunu daxil edin: ");
            payment1.CardCVV = int.Parse(Console.ReadLine());
            payment1.AboutPayment();
        }
    }
}
