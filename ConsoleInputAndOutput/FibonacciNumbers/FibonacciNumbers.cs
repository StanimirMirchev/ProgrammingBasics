using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            int secondDigit = 1;
            int fibb = 0;
            if (number == 1)
            {
                Console.Write(firstDigit);
            }
            else if (number == 2)
            {
                Console.Write(firstDigit);
                Console.Write(" ");
                Console.Write(secondDigit);
                Console.Write(" ");
            }
            else if (number > 2)
            {
                Console.Write(firstDigit);
                Console.Write(" ");
                for (int i = 1; i <= number - 1; i++)
                {
                    fibb = firstDigit + secondDigit;
                    Console.Write(fibb);
                    Console.Write(" ");
                    if (i % 2 == 0)
                    {
                        firstDigit = fibb;
                    }
                    else
                    {
                        secondDigit = fibb;
                    }

                }
            }
        }
    }
}
