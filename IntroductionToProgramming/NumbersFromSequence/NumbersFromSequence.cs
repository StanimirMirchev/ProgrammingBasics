﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromSequence
{
    class NumbersFromSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write("-");
                    Console.WriteLine(i);
                }
            }
        }
    }
}

