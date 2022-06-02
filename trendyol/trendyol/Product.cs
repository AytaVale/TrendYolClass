using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace trendyol
{
    public class Product
    {
        public Product()
        {
            this.Color = new List<string>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public List <string> Color { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public void AddColor (string new_color)
        {
            this.Color.Add(new_color);
        }
        public void WriteProductInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Kateqoriyasi: " + this.Type + "\n");
            info.Append("Mehsulun kodu: " + this.Code + "\n");
            info.Append("Adi: " + this.Name + "\n");
            info.Append("Qiymeti:  " + this.Price + "\n");
            for (int i = 0; i < this.Color.Count; i++)
            {
                info.Append($"Rengi: {i + 1}" + this.Color[i] + "\n");
            }
            info.Append("Olchusu: " + this.Size + "\n");
            info.Append("Materiali: " + this.Material + "\n");
            Console.WriteLine(info);
        }
}
}
