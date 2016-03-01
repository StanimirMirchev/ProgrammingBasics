using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int countNumbers = 0;
            int helpNumber;
            bool isSeven = false;
            do
            {
                number /= 10;
                countNumbers++;
                if (countNumbers == 2)
                {
                    helpNumber = number % 10;
                    if (helpNumber == 7)
                    {
                        isSeven = true;
                    }
                }

            } while (number > 0);
            if (countNumbers < 3)
            {
                isSeven = false;
            }

            Console.WriteLine(isSeven);

        }
    }
}
