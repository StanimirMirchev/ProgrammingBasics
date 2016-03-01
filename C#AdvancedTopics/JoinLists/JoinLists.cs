using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string[] firstEnterdLine = Console.ReadLine().Split(' ');

            List<int> firstList = new List<int>();

            for (int i = 0; i < firstEnterdLine.Length; i++)
            {
                firstList.Add(int.Parse(firstEnterdLine[i]));
            }


            string[] secondEnteredLine = Console.ReadLine().Split(' ');

            List<int> secondList = new List<int>();

            for (int i = 0; i < secondEnteredLine.Length; i++)
            {
                secondList.Add(int.Parse(secondEnteredLine[i]));
            }


            List<int> resultList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                resultList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                resultList.Add(secondList[i]);
            }
            resultList.Sort();
            int f;
            int[] array = new int[resultList.Count];
            for (f = 0; f < resultList.Count - 1; f++)
            {
                if (resultList[f] == resultList[f + 1])
                {
                    array[f]++;
                }
            }
            for (int i = 0; i < resultList.Count; i++)
            {
                if (array[i] == 1)
                {
                    resultList.Remove(resultList[i]);
                }
            }



            for (int i = 0; i < resultList.Count; i++)
            {
                Console.Write(resultList[i] + " ");
            }

        }
    }
}
