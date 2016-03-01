using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Ludmil";
            string lastName = "Ludmilov";

            byte age = 22;
            bool isMale = true;

            ulong personalNumberID = 8306112507;
            uint uniqueNumber = 27560000;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(isMale);
            Console.WriteLine(personalNumberID);
            Console.WriteLine(uniqueNumber);
        }
    }
}
