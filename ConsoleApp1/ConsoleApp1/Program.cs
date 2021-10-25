using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
      public static int Number = Convert.ToInt32(Console.ReadLine());
     
       public static  List<int> Divisor = new List<int>();
        public static int sum=0;

        public static void AddList()
        {


            for (int i = 1; i < Number; i++)
            {

                if (Number % i == 0)
                {
                    Divisor.Add(i);
                   
                }
            }
        }

        //public static void PrintDivisor()
        //{
        //    for (int n = 0; n < Divisor.Count; n++)
        //    {
        //        Console.WriteLine(Divisor[n]);
        //    }

        //}

        public static void addDivisor()
        {
            for (int m = 0; m < Divisor.Count; m++)
            {
                sum = Divisor[m] + sum;

                   
            }
            
        }

        public static void Compare()
        {
            if (sum == Number)
            {
                Console.WriteLine($"{Number} is the Perfect Number");

            }
            else
            {
                Console.WriteLine($"{Number} is the not  Perfect Number");

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check if its Perfect:");

            AddList();
            //PrintDivisor();
            addDivisor();
            Compare();
           

           
           







        }
    }
}
