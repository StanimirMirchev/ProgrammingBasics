using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            //3,4,5 --- 24,25,26
            //check bit at given position
            int number = int.Parse(Console.ReadLine());
            int j = 22;
            int newPosition;
            int currentResult;
            int changeTo;
            for (int i = 3; i <= 5; i++)
            {

                int position = i;
                newPosition = 1 << position;
                currentResult = newPosition & number;

                int result = currentResult >> position;
                j++;
                changeTo = result;
                if (changeTo == 0)
                {
                    newPosition = ~(1 << position);
                    currentResult = number & newPosition;
                    Console.WriteLine(result);
                }
                else if (changeTo == 1)
                {
                    newPosition = 1 << position;
                    result = number | newPosition;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Error , changing value entered!");
                }



            }

        }
    }
}
