using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            List<string> separetedNames = new List<string>();
            string[] enteredNamesFirst = Console.ReadLine().Split(' ');

            string[] enteredNamesSecond = Console.ReadLine().Split(' ');

            for (int i = 0; i < enteredNamesFirst.Length; i++)
            {
                separetedNames.Add(enteredNamesFirst[i]);

                for (int j = 0; j < enteredNamesSecond.Length; j++)
                {
                    if (enteredNamesFirst[i] == enteredNamesSecond[j])
                    {
                        separetedNames.Remove(enteredNamesFirst[i]);
                    }
                }
            }

            foreach (var name in separetedNames)
            {
                Console.WriteLine(name + " ");
            }

        }
    }
}
