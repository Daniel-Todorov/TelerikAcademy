//Write a recursive program for generating and 
//printing all permutations of the numbers 1, 2, ..., n 
//for given integer number n. 

namespace _04.GeneratePermutationsWithoutRepetition
{
    using System;

    public class GeneratePermutationsWithoutRepetition
    {
        public static void Main()
        {
            Console.Write("Please, type the integer number N and press Enter: ");
            int n = int.Parse(Console.ReadLine());

            int[] elements = new int[n];

            for (int i = 1; i <= n; i++)
            {
                elements[i - 1] = i;
            }

            GeneratePermutations(elements, 0);
        }

        private static void GeneratePermutations(int[] result, int k)
        {
            if (k >= result.Length)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                GeneratePermutations(result, k + 1);
                for (int i = k + 1; i < result.Length; i++)
                {
                    Swap(ref result[k], ref result[i]);
                    GeneratePermutations(result, k + 1);
                    Swap(ref result[k], ref result[i]);
                }
            }
        }

        private static void Swap(ref int p1, ref int p2)
        {
            int helper = p1;
            p1 = p2;
            p2 = helper;
        }
    }
}
