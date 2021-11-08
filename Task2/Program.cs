using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number:");
            string Number1 = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string Number2 = Console.ReadLine();

            
            int result = int.Parse(Number1) + int.Parse(Number2);
            Console.Write($"Total sum is: {result}");
            Console.ReadLine();











        }
    }
}
