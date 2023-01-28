using System;
namespace Deliverable_3_Iterative_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number between 1 and 100: ");
            int input = int.Parse(Console.ReadLine());

            Console.Write("Specify the series tye: Even or Odd ");
            string series = Console.ReadLine();

            if (series == "Odd")
            {
                Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }   } 