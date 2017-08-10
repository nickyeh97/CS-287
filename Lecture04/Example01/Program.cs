using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.Org;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Made Elsa  object!
            Person elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    x = 100.0,
                    y = 0.0,
                },
                Theta = 0.0
            };
            elsa.WriteLine();

            elsa.MoveForward(100);
            elsa.TurnRight(90);
            elsa.WriteLine();

            elsa.MoveForward(100);
            elsa.TurnRight(90);
            elsa.WriteLine();

            elsa.MoveForward(100);
            elsa.TurnRight(90);
            elsa.WriteLine();

            elsa.MoveForward(100);
            elsa.TurnRight(90);
            elsa.WriteLine();
        }
    }
}