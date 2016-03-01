using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAreaInArray
{

    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] arrayOfStrings = new string[length];
            for (int j = 0; j < length; j++)
            {
                arrayOfStrings[j] = Console.ReadLine();
            }
            int count = 1;
            int currentCount = 1;
            string currentString = "";
            int i;
            for (i = 0; i < arrayOfStrings.Length - 1; i++)
            {
                if (arrayOfStrings[i] == arrayOfStrings[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > count)
                    {
                        count = currentCount;
                        currentString = arrayOfStrings[i];
                    }
                    currentCount = 1;
                }
            }
            if (currentString == "")
            {
                currentString = arrayOfStrings[0];
            }
            if (currentCount > count)
            {
                count = currentCount;
                currentString = arrayOfStrings[i];
            }

            print_longest_sequence(currentString, count);

        }

        static void print_longest_sequence(string someString, int howTimes)
        {

            Console.WriteLine(howTimes);
            for (int i = 0; i < howTimes; i++)
            {
                Console.WriteLine(someString);
            }
        }
    }
}
