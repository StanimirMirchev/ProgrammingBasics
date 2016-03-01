using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int number1 = 2;
            int number2 = 2;

            string[,] matrix = new string[number1, number2];



            for (int i = 0; i < number1; i++)
            {
                for (int j = 0; i < number2; j++)
                {
                    matrix[i, j] = "" + (char)('a' + i) + (char)('a' + j);
                }
            }
            print_matrix(matrix, number1, number2);
        }


        static void print_matrix(string[,] someMatrix, int number1, int number2)
        {
            for (int i = 0; i < number1; i++)
            {
                for (int j = 0; j < number2; j++)
                {
                    Console.Write(someMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
