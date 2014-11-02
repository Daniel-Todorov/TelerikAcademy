//Write a program based on dynamic programming to 
//solve the "Knapsack Problem": you are given N 
//products, each has weight Wi and costs Ci and a 
//knapsack of capacity M and you want to put inside a 
//subset of the products with highest cost and weight 
//≤ M. The numbers N, M, Wi and Ci are integers in the 
//range [1..500].

namespace _01.KnapsackProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class KnapsackProblem
    {
        static void Main()
        {
            int M = 0;
            Item[] array;
            int arrayLength = 0;
            List<int> results = new List<int>();
            int currentSum = 0;
            int N = 0;

            //Predefined array of items (from the solution).
            array = new Item[]
                {
                    new Item() { Name="beer", Weight = 3, Cost = 2},
                    new Item() { Name="vodka", Weight = 8, Cost = 12},
                    new Item() { Name="cheese", Weight = 4, Cost = 5},
                    new Item() { Name="nut", Weight = 1, Cost = 4},
                    new Item() { Name="ham", Weight = 2, Cost = 3},
                    new Item() { Name="whyskey", Weight = 8, Cost = 13}
                };

            ////NOTE!!! uncomment this and comment the code above to insert custom items.
            //Console.Write("Please, type the number of items N and press Enter: ");
            //arrayLength = int.Parse(Console.ReadLine());
            //array = new Item[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    array[i] = new Item();

            //    Console.WriteLine("Item {0}: ", i);
            //    Console.Write("Name: ");
            //    array[i].Name = Console.ReadLine();
            //    Console.Write("Weight: ");
            //    array[i].Weight = int.Parse(Console.ReadLine());
            //    Console.Write("Cost: ");
            //    array[i].Cost = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //}

            Console.Write("Please, type the capacity M and press Enter: ");
            M = int.Parse(Console.ReadLine());

            N = array.Length;

            var validSubsets = GetAllSubsetsWithSumLesserThan(M, array, ref results, ref currentSum, N);

            var maxValueSubset = GetSubsetWithMaxValue(validSubsets);

            Console.WriteLine("Optimal solution:");
            Console.WriteLine(string.Join(" + ", maxValueSubset.Select(subset => subset.Name)));
        }

        private static List<Item> GetSubsetWithMaxValue(List<List<Item>> validSubsets)
        {
            int maxSum = 0;
            List<Item> result = new List<Item>();

            foreach (var subset in validSubsets)
            {
                int subsetLength = subset.Count;
                int currentSum = 0;

                for (int i = 0; i < subsetLength; i++)
                {
                    currentSum += subset[i].Cost;
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    result = subset;
                }
            }

            return result;
        }

        private static List<List<Item>> GetAllSubsetsWithSumLesserThan(int M, Item[] array, ref List<int> results, ref int currentSum, int N)
        {
            List<List<Item>> resultList = new List<List<Item>>();

            for (int K = 1; K <= N; K++)
            {
                for (int a = 0; a < K; a++)
                {
                    results.Add(a + 1);
                }

                while (results[0] <= N - K + 1)
                {
                    for (int a = K - 1, counter = 0; a > 0; a--, counter++)
                    {
                        if (results[a] > N - counter)
                        {
                            results[a - 1]++;
                            for (int b = a; b < K; b++)
                            {
                                results[b] = results[b - 1] + 1;
                            }
                        }
                    }

                    if (results[results.Count - 1] <= N)
                    {
                        for (int c = 0; c < results.Count; c++)
                        {
                            currentSum = currentSum + array[results[c] - 1].Weight;
                        }

                        if (currentSum <= M)
                        {
                            List<Item> newResultSet = new List<Item>();

                            for (int d = 0; d < results.Count; d++)
                            {
                                newResultSet.Add(array[results[d] - 1]);
                            }

                            resultList.Add(newResultSet);
                        }
                    }

                    results[results.Count - 1]++;
                    currentSum = 0;
                }

                results = new List<int>();
            }

            return resultList;
        }
    }
}
