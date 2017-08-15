using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath.NET;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector v = new Vector(3.0, 4.0);
            Console.WriteLine(v.X);
            Console.WriteLine(v.Y);
            Console.WriteLine(v.Lenght);

            EasyRandom random = new EasyRandom();
            Console.WriteLine(random.NextDouble(3, 21).ToString());
        }
    }
}