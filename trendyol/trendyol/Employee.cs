using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol;

namespace trendyol
{
    public class Employee : Person
    {
        public Employee()
        {

        }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public void EmployeeInfo()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Departamenti: " + this.Department + "\n");
            info.Append("Vezifesi: " + this.Position + "\n");
            info.Append("Maashi: " + this.Salary + "\n");

            Console.WriteLine(info);
        }
    }
}
