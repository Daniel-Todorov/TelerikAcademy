//* Write a program that reads an array of integers 
//and removes from it a minimal number of 
//elements in such way that the remaining array 
//is sorted in increasing order. Print the remaining 
//sorted array. Example: {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

//THIS IS A MODIFIED VERSION OF PROBLEM 16!!!
//The main difference is that we check with a nested for loop if the last element in each combination
//is lower than each of the next elements in the combination.
//Also the combinations start generating from the one with the most posible elements to those with the least.

using System;
using System.Collections.Generic;

class FindSubsetSum
{
    static void Main()
    {
        int[] array;
        List<int> results = new List<int>();
        int N = 0;
        bool isMaxSorted = true;

        Console.Write("Please, type the length of the array and press Enter: ");
        N = int.Parse(Console.ReadLine());
        array = new int[N];
        for (int a = 0; a < N; a++)
        {
            Console.Write("Position {0} - > ", a);
            array[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        for (int K = N; K > 0; K--)
        {
            //Populate the initial results list.
            for (int a = 0; a < K; a++)
            {
                results.Add(a + 1);
            }

            //When the first element in results becomes greater than N - K, then we won't be  able to build up a correct output.
            while (results[0] <= N - K + 1)
            {
                //We check each element in results, starting from the last one.
                for (int a = K - 1, counter = 0; a > 0; a--, counter++)
                {
                    //In case the element is greater than N - counter, that means the previous element should be increased with 1
                    if (results[a] > N - counter)
                    {
                        results[a - 1]++;
                        //After we have increased the previous element, we make sure the following elements have values that are increasing gradually by 1.
                        for (int b = a; b < K; b++)
                        {
                            results[b] = results[b - 1] + 1;
                        }
                    }
                }

                //The nested loops for checking if the elements are ordered.
                if (results[results.Count - 1] <= N)
                {
                    for (int c = 0; c < results.Count - 1; c++)
                    {
                        for (int d = c + 1; d < results.Count; d++)
                        {
                            if (array[results[c] - 1] > array[results[d] - 1])
                            {
                                isMaxSorted = false;
                                break;
                            }
                        }

                    }

                    if (isMaxSorted == true)
                    {
                        //We print the results list
                        Console.Write("{ ");
                        foreach (var item in results)
                        {
                            Console.Write("{0} ", array[item - 1]);
                        }
                        Console.WriteLine(" }");
                        return;
                    }
                }

                //We increase the last element in results with 1 and prepare isMaxSorted for the new loop roration.
                results[results.Count - 1]++;
                isMaxSorted = true;
            }
            //We clear the results for the new loop rotation with different K value.
            results = new List<int>();
        }
    }
}