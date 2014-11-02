//* We are given an array of integers and a number 
//S. Write a program to find if there exists a subset 
//of the elements of the array that has a sum S. 
//Example:
//arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

//THIS IS MODIFIED VERSION OF PROBLEM 21!!!
//The main idea here is that the logic of problem 21 give us all possible combinations of a sequence with N elements.
//What is an integer string then? It is a sequence of N elements too.
//And just like in problem 21, their keys have values like this: 1, 2, 3, ... N.
//They just start with ZERO: 0, 1, 2, ..., N.
//So, using the logic of problem 21 we find all possible combinations of keys in a given integer array.
//Then we just sum up the values of the elements with those keys and check if they equal our sum S.
using System;
using System.Collections.Generic;

class FindSubsetSum
{
    static void Main()
    {
        int S = 0;
        int[] array;
        int arrayLength = 0;
        List<int> results = new List<int>();
        int currentSum = 0;
        int N = 0;

        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        array = new int[arrayLength];
        for (int a = 0; a < arrayLength; a++)
        {
            Console.Write("Position {0} - > ", a);
            array[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        Console.Write("Please, type the sum S and press Enter: ");
        S = int.Parse(Console.ReadLine());

        N = arrayLength;

        for (int K = 1; K <= N; K++)
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
            //We clear the results for the new loop rotation with different K value.
            results = new List<int>();
        }

        //We print a notification to the user that no such substring exists.
        Console.WriteLine("No such substring exists in the array.");
    }
}