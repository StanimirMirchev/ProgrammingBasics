using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class SortingNumber
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] myArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myArray);
            print_array(myArray);
        }
        static void print_array(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
