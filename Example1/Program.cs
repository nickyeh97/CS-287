using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon 寶可夢 = new Pokemon();
            Pokemon pokemon = new Pokemon();

            Console.Write("請輸入Pokemon Name: ");
            try
            {
                寶可夢.PokemonName = Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("Pokemon Name 輸入錯誤!");
            }

            Console.Write("請輸入National No: ");
            try
            {
                寶可夢.NationalNumber = int.Parse(Console.ReadLine());
            }
            catch (IOException e)
            {
                Console.WriteLine("National No 輸入錯誤!");
            }

            Console.Write("請輸入Type: ");
            try
            {
                寶可夢.Type = Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("Type 輸入錯誤!");
            }

            Console.Write("請輸入Species: ");
            try
            {
                寶可夢.Species = Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("Species 輸入錯誤!");
            }

            Console.Write("請輸入Height: ");
            try
            {
                寶可夢.Height = float.Parse(Console.ReadLine());
            }
            catch (IOException e)
            {
                Console.WriteLine("Height 輸入錯誤!");
            }

            Console.Write("請輸入Weight: ");
            try
            {
                寶可夢.Weight = float.Parse(Console.ReadLine());
            }
            catch (IOException e)
            {
                Console.WriteLine("Weight 輸入錯誤!");
            }

            Console.Write("請輸入Abilities: ");
            try
            {
                寶可夢.Abilities = Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("Abilities 輸入錯誤!");
            }

            Console.Write("請輸入Local No: ");
            for (int n = 0; n < 4; n++)
            {
                try
                {
                    寶可夢.LocalNumber[n] = Console.ReadLine();
                }
                catch (IOException e)
                {
                    Console.WriteLine("LocalNo 輸入錯誤!");
                }
            }

            Console.Write("請輸入Japanese: ");
            try
            {
                寶可夢.Japanese = Console.ReadLine();
            }
            catch { Console.WriteLine("Japanese 輸入錯誤!"); }

            Console.Write("\n輸入完畢，您輸入的資料如下:\nPokemon Name: {0}\nNational No: {1}\nType: {2}\nSpecies: {3}\nHeight: {4}\nWeight: {5}\nAbilities: {6}",
                寶可夢.PokemonName,
                寶可夢.NationalNumber,
                寶可夢.Type,
                寶可夢.Species,
                寶可夢.Height,
                寶可夢.Weight,
                寶可夢.Abilities
               );

            Console.Write("\nLocal No:\n");
            foreach (string item in 寶可夢.LocalNumber)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Japanese: {0}", 寶可夢.Japanese);
        }
    }
}