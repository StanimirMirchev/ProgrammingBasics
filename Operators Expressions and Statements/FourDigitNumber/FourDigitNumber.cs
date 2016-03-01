using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Enter four digit number: ");
                number = int.Parse(Console.ReadLine());

            } while (number < 1000 || number > 9999);


            int transform = 1000;
            int numberInReverseOrder = 0;
            int digit;

            int number2 = number;
            int number3 = number;

            int lastDigit = number2 % 10;
            int withoutLastDigit = number2 / 10;
            int lastDigitAhead = 1000 * lastDigit + withoutLastDigit;

            int thirdNumber = (number3 / 10) % 10;
            int secondNumber = (number / 100) % 10;

            int fourthCondition = 1000 * (number3 / 1000) + 100 * thirdNumber + 10 * secondNumber + (number3 % 10);


            int sumOfDigits = 0;
            do
            {
                sumOfDigits += number % 10;
                digit = number % 10;
                numberInReverseOrder += (digit * transform);
                transform /= 10;
                number /= 10;

            } while (number > 0);

            Console.Write("Sum of digits: ");
            Console.WriteLine(sumOfDigits);
            Console.Write("Number in reversed order: ");
            Console.WriteLine(numberInReverseOrder);
            Console.Write("Last digit putted ahead: ");
            Console.WriteLine(lastDigitAhead);
            Console.Write("Third and second digit are reversed: ");
            Console.WriteLine(fourthCondition);

        }
    }
}
