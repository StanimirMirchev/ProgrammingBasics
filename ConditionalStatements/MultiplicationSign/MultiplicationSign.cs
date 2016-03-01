using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());

            if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
            {
                Console.WriteLine("0");
            }
            else if (numberOne < 0 && numberTwo < 0 && numberThree < 0)
            {
                Console.WriteLine("-");
            }
            else if (numberOne < 0 && (numberTwo > 0 && numberThree > 0))
            {
                Console.WriteLine("-");
            }
            else if ((numberOne > 0 && numberTwo > 0) && numberThree < 0)
            {
                Console.WriteLine("-");
            }
            else if ((numberOne > 0 && numberThree > 0) && numberTwo < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }

        }
    }
}
