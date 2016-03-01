using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDates
{
    class TwoDates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date: ");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime firstDate = new DateTime(year, month, day);

            Console.WriteLine("Enter second date: ");
            int day1 = int.Parse(Console.ReadLine());
            int month1 = int.Parse(Console.ReadLine());
            int year1 = int.Parse(Console.ReadLine());

            DateTime secondDate = new DateTime(year1, month1, day1);

            Console.WriteLine("Difference is {0}", firstDate - secondDate);
        }
    }
}
