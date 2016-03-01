using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitAtGivenPosition
{

    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int changeTo = int.Parse(Console.ReadLine());

            if (changeTo == 0)
            {
                int newPosition = ~(1 << position);
                int result = number & newPosition;
                Console.WriteLine(result);
            }
            else if (changeTo == 1)
            {
                int newPosition = 1 << position;
                int result = number | newPosition;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error , changing value entered!");
            }

        }
    }
}
