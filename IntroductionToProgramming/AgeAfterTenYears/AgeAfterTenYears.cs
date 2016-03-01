using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfterTenYears
{

    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your DOB:");
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int ageNow;


            if (DateTime.Now.Month < month)
            {
                ageNow = DateTime.Now.Year - year - 1;
            }
            else if (DateTime.Now.Month == month && DateTime.Now.Day < day)
            {
                ageNow = DateTime.Now.Year - year - 1;
            }
            else
            {
                ageNow = DateTime.Now.Year - year;
            }

            int ageAfterTenYears = ageNow + 10;

            Console.WriteLine("You are now {0} years old and after 10 years you will be {1} years old!!!", ageNow, ageAfterTenYears);



        }
    }
}


