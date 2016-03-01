using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExpressions
{
    class OddOrEven
    {
        static void Main(string[] args)
        {   
            bool isOdd;
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                isOdd = true;
            }
            else
            {
                isOdd = false;
            }
            Console.WriteLine(isOdd);
            
        }
    }
}
