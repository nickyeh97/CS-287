using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int N1;
            int N2;
            int N3;
            int N4;

            int[] inputNumber;
            int[] randomNumber;

            int R1;
            int R2;
            int R3;
            int R4;

            string status = "null";
            //int index = 0;
            int Acounter = 0;
            int Bcounter = 0;

            Console.WriteLine("Give me 4 number!");

            //型態轉換
            string input = Console.ReadLine();
            int number;
            int.TryParse(input, out number);
            Console.WriteLine(input);

            N1 = number / 1000;
            N2 = (number - N1 * 1000) / 100;
            N3 = (number - N1 * 1000 - N2 * 100) / 10;
            N4 = number - N1 * 1000 - N2 * 100 - N3 * 10;

            Console.WriteLine("input : {0},{1},{2},{3}"
                , N1
                , N2
                , N3
                , N4);

            //產生亂數
            Random rnd = new Random();
            randomNumber = new int[4];

            for (int i = 0; i < randomNumber.Length; i++)
                randomNumber[i] = rnd.Next(0, 10);

            R1 = randomNumber[0];
            R2 = randomNumber[1];
            R3 = randomNumber[2];
            R4 = randomNumber[3];

            while (R1 == R2 || R1 == R3 || R1 == R4)
            {
                R2 = rnd.Next(0, 10);
                R3 = rnd.Next(0, 10);
                R4 = rnd.Next(0, 10);
            }
            while (R2 == R3 || R2 == R4)
            {
                R3 = rnd.Next(0, 10);
                R4 = rnd.Next(0, 10);
            }
            if (R3 == R4)
                R4 = rnd.Next(0, 10);

            randomNumber[0] = R1;
            randomNumber[1] = R2;
            randomNumber[2] = R3;
            randomNumber[3] = R4;

            Console.WriteLine("Random : {0},{1},{2},{3}"
                , R1
                , R2
                , R3
                , R4);

            //迴圈判斷式
            inputNumber = new int[4];
            inputNumber[0] = N1;
            inputNumber[1] = N2;
            inputNumber[2] = N3;
            inputNumber[3] = N4;

            for (int k = 0; k < inputNumber.Length; k++)
            {
                for (int m = 0; m < randomNumber.Length; m++)
                {
                    if (inputNumber[k] == randomNumber[m] && k == m)
                    {
                        status += "U GET 1A!";
                        Acounter++;
                        Console.WriteLine("inputNumber{0} correct!\n", k);
                    }
                    else if (inputNumber[k] == randomNumber[m] && k != m)
                    {
                        status += "U GET 1b!";
                        Bcounter++;
                        Console.WriteLine("inputNumber{0} at wrong position!\n", k);
                    }
                    else
                    {
                        Console.WriteLine("inputNumber{0} not here!\n", k);
                    }
                }
            }
            /* if - else if 判斷式
            if (N1 == R1)
            {
                status += "U GET 1A!";
                index = 1;
                Acounter++;
            }
            else if (N1 == R2)
            {
                status += "U GET 1b!";
                index = 2;
                Bcounter++;
            }
            else if (N1 == R3)
            {
                status += "U GET 1b!";
                index = 3;
                Bcounter++;
            }
            else if (N1 == R4)
            {
                status += "U GET 1b!";
                index = 4;
                Bcounter++;
            }

            if (N2 == R2)
            {
                status += "U GET 1A!";
                index = 5;
                Acounter++;
            }
            else if (N2 == R1)
            {
                status += "U GET 1b!";
                index = 6;
                Bcounter++;
            }
            else if (N2 == R3)
            {
                status += "U GET 1b!";
                index = 7;
                Bcounter++;
            }
            else if (N2 == R4)
            {
                status += "U GET 1b!";
                index = 8;
                Bcounter++;
            }

            if (N3 == R3)
            {
                status += "U GET 1A!";
                index = 9;
                Acounter++;
            }
            else if (N3 == R1)
            {
                status += "U GET 1b!";
                index = 10;
                Bcounter++;
            }
            else if (N3 == R2)
            {
                status += "U GET 1b!";
                index = 11;
                Bcounter++;
            }
            else if (N3 == R4)
            {
                status += "U GET 1b!";
                index = 12;
                Bcounter++;
            }

            if (N4 == R4)
            {
                status += "U GET 1A!";
                index = 13;
                Acounter++;
            }
            else if (N4 == R1)
            {
                status += "U GET 1b!";
                index = 14;
                Bcounter++;
            }
            else if (N4 == R2)
            {
                status += "U GET 1b!";
                index = 15;
                Bcounter++;
            }
            else if (N4 == R3)
            {
                status += "U GET 1b!";
                index = 16;
                Bcounter++;
            }

            switch (index)
            {
                case 1:
                    Console.WriteLine("N1 correct");
                    break;

                case 2:
                    Console.WriteLine("N1 at wrong position");
                    break;

                case 3:
                    Console.WriteLine("N1 at wrong position");
                    break;

                case 4:
                    Console.WriteLine("N1 at wrong position");
                    break;

                default:
                    Console.WriteLine("N1 is not in the Random!");
                    break;
            }*/

            Console.WriteLine("U total get {0}A{1}B !", Acounter, Bcounter);
        }
    }
}