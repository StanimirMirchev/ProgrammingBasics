using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            bool prime = false;
            int number = int.Parse(Console.ReadLine());
            for (int i = 3; i <= number; i++)
            {
                prime = true;
                for (int n = 2; n <= i - 1; n++)
                {
                    if (i % n == 0)
                    {
                        prime = false;
                    }
                }

            }
            if (prime)
            {
                Console.WriteLine(prime);
            }
            else
            {
                Console.WriteLine(prime);
            }
        }
    }
}
