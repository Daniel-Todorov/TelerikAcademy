//Write a program that reads two numbers N and K 
//and generates all the combinations of K distinct 
//elements from the set [1..N]. Example:
//N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Collections.Generic;

class GenerateAllVariationsOfDifferentElements
{
    static void Main()
    {
        int N = 0;
        int K = 0;
        List<int> results = new List<int>();

        //Read N and K.
        Console.WriteLine("Please, type the length of the set [1..N] and press Enter: ");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the length of the combinations K and press Enter: ");
        K = int.Parse(Console.ReadLine());

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

            if (results[results.Count - 1] <= N)
            {
                //We print the results list
                Console.Write("{ ");
                foreach (var item in results)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine(" }");
            }

            //We increase the last element in results with 1.
            results[results.Count - 1]++;
        }
    }
}
