using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppleStoreLibrary1;

namespace Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = 1,
                Name = "iphone7",
                Price = 28900,
                Categories = new string[] { "iPhone" }
            };

            /* Do not use above writing skill , use up one.
            product1.Id = 1;
            product1.Name = "iphone";
            product1.Price = 28900;
            product1.Categories = new string[] { "iPhone" };
            */

            Product product2 = new Product()
            {
                Id = 2,
                Name = "iphone 7s",
                Price = 31900,
                Categories = new string[] { "iPhones" }
            };

            Product[] products = new Product[]
            {
                new Product()
                {
                     Id = 1,
                        Name = "iphone7",
                     Price = 28900,
                     Categories = new string[] { "iPhone" }
                },

                new Product()
                {
                     Id = 2,
                    Name = "iphone 7s",
                    Price = 31900,
                   Categories = new string[] { "iPhones" }
                }
            };

            Console.WriteLine(products[0].Name);
            Console.WriteLine(products[1].Name);
            Console.WriteLine("共有{0}個產品", products.Length);
        }
    }
}