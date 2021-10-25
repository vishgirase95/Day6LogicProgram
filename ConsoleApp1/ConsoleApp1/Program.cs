using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");


          
           
           
            int  UserInput = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] series = new int[UserInput + 1];
            series[0] = 0;
            series[1] = 1;

            switch (UserInput)
            {
                case 1:
                    Console.WriteLine(series[0]);
                    break;

                case 2:
                    Console.WriteLine(series[0]);

                    Console.WriteLine(series[1]);
                    break;


                default:
                    Console.WriteLine(series[0]);
                    Console.WriteLine(series[1]);


                    for (i = 2; i < UserInput; i++)

                    {


                        series[i] = series[i - 1] + series[i - 2];



                        Console.WriteLine(series[i]);
                    }
                    break;
            }



          
          }
    }
}
