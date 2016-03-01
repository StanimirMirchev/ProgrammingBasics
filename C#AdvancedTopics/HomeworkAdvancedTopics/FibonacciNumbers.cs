using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdvancedTopics
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Fib(number);
        }

        static void Fib(int n)
        {
            if (n == 0)
                Console.WriteLine(1);
            if (n == 1)
                Console.WriteLine(1);
            
            int currentSum = 0;
            int secondNumber = 1;
            for (int i = 1; i <= n; i++)
            {

                currentSum += i;
                
            }
            Console.WriteLine(currentSum);

        }
    }
}
