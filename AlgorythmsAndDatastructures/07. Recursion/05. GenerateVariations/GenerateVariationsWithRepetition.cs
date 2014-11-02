//Write a recursive program for generating and 
//printing all ordered k-element subsets from n-
//element set.

namespace _05.GenerateVariationsWithRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenerateVariationsWithRepetition
    {
        public static void Main()
        {
            Console.Write("Please, type the length K of the subset and press Enter: ");
            int k = int.Parse(Console.ReadLine());

            string[] predefinedSet = new string[] { "hi", "a", "b" };
            int n = predefinedSet.Length;

            GenerateVariations(0, n, new string[k], predefinedSet);
        }

        private static void GenerateVariations(int index, int n, string[] result, string[] set)
        {
            if (index >= result.Length)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    result[index] = set[i];
                    GenerateVariations(index + 1, n, result, set);
                }
            }
        }
    }
}
