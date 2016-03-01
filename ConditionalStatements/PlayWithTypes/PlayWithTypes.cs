using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithTypes
{
    class PlayWithTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int usersChoice = int.Parse(Console.ReadLine());

            if (usersChoice == 1)
            {
                Console.WriteLine("Enter integer number: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine(number1);
            }
            else if (usersChoice == 2)
            {
                Console.WriteLine("Enter double number: ");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine(number1);
            }
            else if (usersChoice == 3)
            {
                Console.WriteLine("Enter string : ");
                string number1 = Console.ReadLine();
                Console.WriteLine(number1);
            }

        }
    }
}
