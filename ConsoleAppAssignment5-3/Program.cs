using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;

            int fibonacci;

            for (int i = 0; i < 10; i++)
            {
                fibonacci = num1 + num2;
                Console.WriteLine(num1);
                num1 = num2;
                num2 = fibonacci;
            }
            Console.ReadKey();
        }
    }
}
