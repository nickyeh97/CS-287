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
            string input;
            int Acounter = 0;
            int Bcounter = 0;

            Console.WriteLine("Give me 4 number!");
            GetRandomNumber();

            do
            {
                //型態轉換
                input = Console.ReadLine();
                int number;
                int.TryParse(input, out number);

                Acounter = 0;
                Bcounter = 0;

                N1 = number / 1000;
                N2 = (number - N1 * 1000) / 100;
                N3 = (number - N1 * 1000 - N2 * 100) / 10;
                N4 = number - N1 * 1000 - N2 * 100 - N3 * 10;

                Console.WriteLine("input : {0},{1},{2},{3}"
                    , N1
                    , N2
                    , N3
                    , N4);
                GetAnswer();
                if (Acounter == 4)
                    return;
            } while (input != null);

            //產生亂數
            void GetRandomNumber()
            {
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
            }

            //迴圈判斷式
            void GetAnswer()
            {
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
                            //Console.WriteLine("inputNumber{0} correct!\n", k);
                        }
                        else if (inputNumber[k] == randomNumber[m] && k != m)
                        {
                            status += "U GET 1b!";
                            Bcounter++;
                            //Console.WriteLine("inputNumber{0} at wrong position!\n", k);
                        }
                        else
                        {
                            //Console.WriteLine("inputNumber{0} not here!\n", k);
                        }
                    }
                }

                Console.WriteLine("U total get {0}A{1}B !", Acounter, Bcounter);
            }
        }
    }
}