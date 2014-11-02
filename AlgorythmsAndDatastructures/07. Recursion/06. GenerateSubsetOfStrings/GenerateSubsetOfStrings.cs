//Write a program for generating and printing all 
//subsets of k strings from given set of strings.

namespace _06.GenerateSubsetOfStrings
{
    using System;

    public class GenerateSubsetOfStrings
    {
        public static void Main()
        {
            Console.Write("Please, type the length K of the subset and press Enter: ");
            int k = int.Parse(Console.ReadLine());

            string[] predefinedSet = new string[] { "test", "rock", "fun" };
            int n = predefinedSet.Length;

            GenerateCombinations(0, 0, new string[k], predefinedSet);
        }

        private static void GenerateCombinations(int index, int start, string[] k, string[] n)
        {
            if (index >= k.Length)
            {
                Console.WriteLine(string.Join(" ", k));
            }
            else
            {
                for (int i = start; i < n.Length; i++)
                {
                    k[index] = n[i];
                    GenerateCombinations(index + 1, i + 1, k, n);
                }
            }
        }
    }
}
