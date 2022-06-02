using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol
{
    public class Person
    {
        public Person()
        {

            this.Address = new List<string>();
            this.Phones = new List<string>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Phones { get; set; }
        public List<string> Address { get; set; }
        public string Gender { get; set; }

        public void ChangePassword(string new_password)
        {
            //
        }
        public void AddPhones(string new_phoneNumer)
        {
            this.Phones.Add(new_phoneNumer);
        }
        public void AddAddress(string new_addres)
        {
            this.Address.Add(new_addres);
        }
        public void WritePersonInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Adi: " + this.Name + "\n");
            info.Append("Soyadi: " + this.Surname + "\n");
            info.Append("Ata adi: " + this.FatherName + "\n");
            info.Append("E-mail: " + this.Email + "\n");
            info.Append("Password: " + this.Password + "\n");
            for (int i = 0; i < this.Phones.Count; i++)
            {
                info.Append($"Phone Number: {i + 1}" + this.Phones[i] + "\n");
            }
            for (int i = 0; i < this.Address.Count; i++)
            {
                info.Append($"Adres: {i + 1}" + this.Address[i] + "\n");
            }
            Console.WriteLine(info);
        }
    }
}
