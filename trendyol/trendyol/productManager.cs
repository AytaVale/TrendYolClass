using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace trendyol
{
    class productManager
    {
        public void ManageProduct()
        {
            Product product1 = new Product();
            Console.Write("Mehsulun hansi kateqoriyaya aid oldugunu qeyd edin: ");
            product1.Type = Console.ReadLine();
            Console.Write("Mehsulun kodunu qeyd edin: ");
            product1.Code = Console.ReadLine();
            Console.Write("Mehsulun adini qeyd edin: ");
            product1.Name = Console.ReadLine();
            Console.Write("Mehsulun qiymetini qeyd edin: ");
            product1.Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Mehsula endirim varmi? He/Yox ");
            string discount = Console.ReadLine();
            if (discount == "he")
            {
                Console.WriteLine("Endirim faizi ne qederdir?");
                int percent = int.Parse(Console.ReadLine());
                decimal newPrice = product1.Price - ((product1.Price * percent)/ 100);
                product1.Price = newPrice;
                Console.WriteLine("Mehsulun endirimli qiymeti: " +newPrice);
            }
            else
            {
                Console.WriteLine("Endirim muddeti bitmishdir.");
            }
                Console.Write("Mehsulun rengini qeyd edin: ");
                string response = string.Empty;
            do
            {
                string item = Console.ReadLine();
                product1.AddColor(item);
                Console.WriteLine("Bashqa reng elave etmek isteyirsiniz? He/yox");
                response = Console.ReadLine();
            } 
            while (response == "he");
            Console.WriteLine("Mehsulun olchusunu qeyd edin: ");
            product1.Size = Console.ReadLine();
            Console.WriteLine("Mehsulun materialini qeyd edin: ");
            product1.Material = Console.ReadLine();

            product1.WriteProductInformation();
        }
    }
}
