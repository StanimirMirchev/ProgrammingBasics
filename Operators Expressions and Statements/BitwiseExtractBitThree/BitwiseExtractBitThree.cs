using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBitThree
{
    class BitwiseExtractBitThree
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int p = 3;
            uint nRightP = number >> p;
            uint bit = nRightP & 1;
            Console.WriteLine(bit);

        }
    }
}
