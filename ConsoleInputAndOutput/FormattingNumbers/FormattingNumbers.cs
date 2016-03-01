using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            while (numberOne < 0 || numberOne > 500)
            {
                Console.WriteLine("Enter a: ");
                numberOne = int.Parse(Console.ReadLine());
            }
            float numberTwo = float.Parse(Console.ReadLine());
            float numberThree = float.Parse(Console.ReadLine());

            string hexValue = numberOne.ToString("X");
            string binaryValue = Convert.ToString(numberOne, 2);

            Console.WriteLine("|{0}          |{1}          |{2:0.00}          |{3:0.000}          ", hexValue, binaryValue, numberTwo, numberThree);
        }
    }
}
