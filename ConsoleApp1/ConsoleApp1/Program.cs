using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int Reverse = 0;
            Console.WriteLine("Enter the number to be reverse:");
            int Number = Convert.ToInt32(Console.ReadLine());

            while(Number>0)
            {
                int LastDigit = Number % 10;
                Reverse = (Reverse * 10) + LastDigit;
                Number = Number / 10;
            }
            Console.WriteLine(Reverse);





        }
    }
}
