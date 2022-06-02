using System;
using Trendyol;

namespace trendyol
{
    class Program
    {
        static void Main(string[] args)
        {
            personManager personManager = new personManager();
            personManager.ManagePerson();
            manager manager = new manager();
            manager.Manage();
            productManager productManager = new productManager();
            productManager.ManageProduct();
            paymentManager paymentManager = new paymentManager();
            paymentManager.managePayment();

        }
    }
}
