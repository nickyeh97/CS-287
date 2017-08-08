using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product1 = new Product();

            Console.Write("請輸入產品1號的Id: ");
            try
            {
                product1.Id = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n產品1號的Id 輸入格式錯誤!");
                return;
            }

            Console.Write("請輸入產品1號的Name: ");
            try
            {
                product1.Name = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("\n產品1號的Name 輸入格式錯誤!");
                return;
            }

            Console.Write("請輸入產品1號的Price ");
            try
            {
                product1.Price = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n產品1號的Price 輸入格式錯誤!");
                return;
            }

            Console.Write("請輸入產品1號的Categories: ");
            try
            {
                product1.Categories = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("\n產品1號的Categories 輸入格式錯誤!");
                return;
            }

            Console.Write("\n輸入完畢，您輸入的資料如下:\n產品1號的Id: {0}\n產品1號的Name: {1}\n產品1號的Price: {2}\n產品1號的Categories: {3}\n",
                product1.Id,
                product1.Name,
                product1.Price,
                product1.Categories
               );
        }
    }
}