using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrimeNumber
{
    class CheckPrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine(prime);
        }
    }
}
