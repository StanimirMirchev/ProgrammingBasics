using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne < numberTwo)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
            }
            else if (numberOne > numberTwo)
            {
                int currentNumber;
                currentNumber = numberOne;
                numberOne = numberTwo;
                numberTwo = currentNumber;
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);

            }
        }
    }
}
