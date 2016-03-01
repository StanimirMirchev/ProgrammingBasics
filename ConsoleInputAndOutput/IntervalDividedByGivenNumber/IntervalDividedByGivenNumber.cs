using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalDividedByGivenNumber
{

    class IntervalDividedByGivenNumber
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = numberOne; i <= numberTwo; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("Numbers are: ");
            Console.WriteLine(count);

        }
    }
}
