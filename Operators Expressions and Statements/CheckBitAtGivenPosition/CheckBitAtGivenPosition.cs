using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int newPosition = 1 << position;
            int currentResult = newPosition & number;
            int result = currentResult >> position;
            Console.WriteLine(result);
        }
    }
}
