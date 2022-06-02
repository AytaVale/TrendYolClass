using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trendyol;

namespace trendyol
{
    class personManager
    {
        public void ManagePerson()
        {
             Person person1 = new Person();

            Console.WriteLine("Adinizi qeyd edin");
            person1.Name = Console.ReadLine();

            Console.WriteLine("Soyadinizi qeyd edin");
            person1.Surname = Console.ReadLine();

            Console.WriteLine("Ata adinizi qeyd edin");
            person1.FatherName = Console.ReadLine();

            Console.WriteLine("E-mail qeyd edin");
            person1.Email = Console.ReadLine();

            Console.WriteLine("Shifrenizi qeyd edin");
            person1.Password = Console.ReadLine();

            Console.WriteLine("Telefonuzu qeyd edin");
            string response = string.Empty;
            do
            {

                string item = Console.ReadLine();
                person1.AddPhones(item);
                Console.WriteLine("Bashqa telefon varmi? He/yox");
                response = Console.ReadLine();
            }
            while (response == "he");
            Console.WriteLine("Musterinin adresini giriniz");
            string responseAddress = string.Empty;
            do
            {

                string item = Console.ReadLine();
                person1.AddAddress(item);
                Console.WriteLine("Bashqa adres varmi? He/yox");
                responseAddress = Console.ReadLine();
            }
            while (responseAddress == "he");
            person1.WritePersonInformation();
        }
    }
}
