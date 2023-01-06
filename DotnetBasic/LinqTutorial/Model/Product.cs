using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public Product()
        {

        }
        public override string ToString()
        {
            return "Product { Name : " + this.Name + ", Price: Rp. " + this.Price + "}";
        }
        public static List<Product> GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Mie Yamien", 15000),
                new Product("Bakso Astagfirullah", 20000),
                new Product("Bubur Mang Salim", 8000),
                new Product("Mixue Es Krim Coklat",10000),
                new Product("Mixue Es Krim Vanilla",10000),
                new Product{Name = "Mixue Es Krim Stroberi", Price = 10000}
            };
            return products;
        }
        public static void SampleFilterProduct()
        {
            List<Product> products = GetData();

            IEnumerable<Product> productFilter = from item in products where item.Price >= 12500 select item;

            foreach (var product in productFilter)
            {
                Console.WriteLine(product);
            }
        }
        public static void SampleFilterByName()
        {
            List<Product> products = GetData();

            IEnumerable<Product> productsFilter = from product in products where product.Name.ToLower().Contains("Mixue") select product;
            foreach(var product in productsFilter)
            {
                Console.WriteLine(product);
            }
        }
    }
}
