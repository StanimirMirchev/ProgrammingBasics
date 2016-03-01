using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            int enteredNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= enteredNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
