using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int score;
            if (number >= 1 && number <= 3)
            {
                score = number * 10;
                Console.WriteLine(score);
            }
            else if (number >= 4 && number <= 6)
            {
                score = number * 100;
                Console.WriteLine(score);
            }
            else if (number >= 7 && number <= 9)
            {
                score = number * 100;
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("Invalid score!");
            }


        }
    }
}
