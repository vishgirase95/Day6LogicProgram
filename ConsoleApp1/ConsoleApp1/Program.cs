using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            int count = 0;
            Console.WriteLine("Enter the zero to start timmer and then press any key to stop");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
            {

                while (!Console.KeyAvailable)
                {
                    count++;
                    



                }

            }
            int sec = count / 1000;
            Console.WriteLine($"{sec} mili sec");




        }
    }
}
