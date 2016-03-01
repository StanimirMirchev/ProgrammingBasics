using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimeInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some range: ");
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            print_list(FindPrimesInRange(startNum, endNum));


        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> myList = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (isPrime(i))
                {
                    myList.Add(i);
                }
            }

            return myList;
        }

        static bool isPrime(int number)
        {

            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            return prime;
        }

        static void print_list(List<int> someList)
        {
            for (int i = 0; i < someList.Count; i++)
            {
                Console.WriteLine(someList[i]);
            }
        }
    }
}
