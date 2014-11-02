//Modify the previous program to skip duplicates.

namespace _02.GenerateCoombinationsWithDuplicates
{
    using System;

    public class GenerateCombinationsWithDuplicates
    {
        public static void Main()
        {
            Console.Write("Please, type the number of elements K and press Enter: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Please, type the number N of the set of elements and press Enter: ");
            int n = int.Parse(Console.ReadLine());

            GenerateCombinations(0, 1, k, n, new int[k]);
        }

        private static void GenerateCombinations(int index, int start, int k, int n, int[] result)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    result[index] = i;
                    GenerateCombinations(index + 1, i + 1, k, n, result);
                }
            }
        }
    }
}
