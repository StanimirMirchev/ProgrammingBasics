using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            uint nRightP = number >> p;
            uint bit = nRightP & 1;
            Console.WriteLine(bit);
        }
    }
}
