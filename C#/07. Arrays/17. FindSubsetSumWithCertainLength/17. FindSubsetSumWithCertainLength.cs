//* Write a program that reads three integer 
//numbers N, K and S and an array of N elements 
//from the console. Find in the array a subset of K 
//elements that have sum S or indicate about its absence.

//THIS IS MODIFIED VERSION OF PROBLEM 16!!!
//This is just a small piece of problem 16.
using System;
using System.Collections.Generic;

class FindSubsetSum
{
    static void Main()
    {
        int S = 0;
        int[] array;
        List<int> results = new List<int>();
        int currentSum = 0;
        int N = 0;
        int K = 0;

        Console.Write("Please, type the length of the array N and press Enter: ");
        N = int.Parse(Console.ReadLine());
        array = new int[N];
        for (int a = 0; a < N; a++)
        {
            Console.Write("Position {0} - > ", a);
            array[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        Console.Write("Please, type the length of the subset K and press Enter: ");
        K = int.Parse(Console.ReadLine());

        Console.Write("Please, type the sum S and press Enter: ");
        S = int.Parse(Console.ReadLine());

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

            //Due to the algorith logic, it is posible that we receive a substring that ends with invalid last element which is greater than N.
            //That why we have to check if the subtring is current before we can continue with our operations.
            //In case it is not correct, we just ignore it.
            if (results[results.Count - 1] <= N)
            {
                //If it is a valid substring, we find the sum of its elements.
                for (int c = 0; c < results.Count; c++)
                {
                    currentSum = currentSum + array[results[c] - 1];
                }

                //We check if the current substring has the Sum. If it does, we print the currents substring.
                if (currentSum == S)
                {
                    Console.Write("yes ( ");
                    for (int d = 0; d < results.Count; d++)
                    {
                        Console.Write("{0} ", array[results[d] - 1]);
                    }
                    Console.WriteLine(")");
                    return;
                }
            }

            //We increase the last element in results with 1 and prepare the currentSum for the new loop roration.
            results[results.Count - 1]++;
            currentSum = 0;
        }

        //We print a notification to the user that no such substring exists.
        Console.WriteLine("No such substring exists in the array.");
    }
}