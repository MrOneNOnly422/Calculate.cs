using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                if (number % 11 == 0)
                {
                    Console.WriteLine($"{number} is divisible by 11");
                }
                else
                {
                    Console.WriteLine($"{number} is not divisible by 11");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}
