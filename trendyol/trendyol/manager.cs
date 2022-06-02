using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trendyol
{
    class manager
    {
        public void Manage()
        {
            Console.WriteLine("Iscisiniz yoxsa musteri? ");
            string request = Console.ReadLine();
            if (request == "isci")
            {
                Employee employee1 = new Employee();
                Console.WriteLine("Hansi departamentde ishleyirsiniz? ");
                employee1.Department = Console.ReadLine();
                Console.Write("Vezifenizi qeyd edin: ");
                employee1.Position = Console.ReadLine();
                Console.Write("Maashinizi qeyd edin: ");
                employee1.Salary = int.Parse(Console.ReadLine());
                employee1.EmployeeInfo();
            }
            else if (request == "musteri")
            {
                Customer customer1 = new Customer();
                Console.Write("Musteri nomrenizi daxil edin: ");
                customer1.CustomerNumber = Console.ReadLine();
                Console.WriteLine(customer1.CustomerNumber);
            }
        }
    }
}
