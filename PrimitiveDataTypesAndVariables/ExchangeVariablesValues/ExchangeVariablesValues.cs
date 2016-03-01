using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariablesValues
{
    class ExchangeVariablesValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.Write(a + " ");
            Console.WriteLine(b);

            int c;
            c = a;
            a = b;
            b = c;

            Console.Write(a + " ");
            Console.WriteLine(b);
        }
    }
}
