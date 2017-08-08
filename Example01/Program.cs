using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string PokemonName = null;
            int nationalNumber = 0;
            string Type = null;
            string Species = null;
            float Height = 0;
            float Weight = 0;
            string[] localNumber = new string[5];
            string Abilities = null;
            string Japanese = null;
            int n = 0;

            Console.Write("請輸入Pokemon Name: ");
            try
            {
                PokemonName = Console.ReadLine();
            }
            catch { Console.WriteLine("Pokemon Name 輸入錯誤!"); }

            Console.Write("請輸入National No: ");
            try
            {
                nationalNumber = int.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("National No 輸入錯誤!"); }

            Console.Write("請輸入Type: ");
            try
            {
                Type = Console.ReadLine();
            }
            catch { Console.WriteLine("Type 輸入錯誤!"); }

            Console.Write("請輸入Species: ");
            try
            {
                Species = Console.ReadLine();
            }
            catch { Console.WriteLine("Species 輸入錯誤!"); }

            Console.Write("請輸入Height: ");
            try
            {
                Height = float.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Height 輸入錯誤!"); }

            Console.Write("請輸入Weight: ");
            try
            {
                Weight = float.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Weight 輸入錯誤!"); }

            Console.Write("請輸入Abilities: ");
            try
            {
                Abilities = Console.ReadLine();
            }
            catch { Console.WriteLine("Abilities 輸入錯誤!"); }

            Console.Write("請輸入Local No: ");
            do
            {
                n++;
                localNumber[n] = Console.ReadLine();
            } while (n < 4);

            Console.Write("請輸入Japanese: ");
            Japanese = Console.ReadLine();

            Console.Write("\n輸入完畢，您輸入的資料如下:\nPokemon Name: {0}\nNational No: {1}\nType: {2}\nSpecies: {3}\nHeight: {4}\nWeight: {5}\nAbilities: {6}",
                PokemonName,
                nationalNumber,
                Type,
                Species,
                Height,
                Weight,
                Abilities
               );

            Console.Write("\nLocal No:\n");
            /* n = 0;
             do
             {
                 n++;
                 Console.WriteLine(localNumber[n]);
             } while (n < 4);*/

            foreach (string item in localNumber)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Japanese: {0}", Japanese);
        }
    }
}