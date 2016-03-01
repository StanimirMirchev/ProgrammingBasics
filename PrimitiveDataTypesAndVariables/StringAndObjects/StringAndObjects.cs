using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObjects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";

            object concat = first + second;

            string third = (string)concat;

            Console.WriteLine(third);

        }
    }
}
