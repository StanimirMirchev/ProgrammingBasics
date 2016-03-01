using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            decimal sum = 0;
            string currentString = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != ' ')
                {
                    currentString = currentString + numbers[i];

                }
                else
                {
                    sum = sum + (decimal.Parse(currentString));
                    currentString = String.Empty;
                }

            }
            sum = sum + (decimal.Parse(currentString));
            Console.WriteLine(sum);
        }
    }
}
