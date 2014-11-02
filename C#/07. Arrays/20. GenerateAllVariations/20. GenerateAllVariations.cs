//Write a program that reads two numbers N and 
//K and generates all the variations of K elements 
//from the set [1..N]. Example:
//N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;
using System.Collections.Generic;

class GenerateAllVariations
{
    static void Main()
    {
        int N = 0;
        int K = 0;
        int counter = 0;
        List<int> results = new List<int>();

        //Read N and K.
        Console.Write("Please, type the length N of the set [1..N] and press Enter: ");
        N = int.Parse(Console.ReadLine());
        Console.Write("Please, type the number K of the elements used for combinations and press Enter: ");
        K = int.Parse(Console.ReadLine());

        //Populate results with '1' at every position.
        for (int a = 0; a < K; a++)
        {
            results.Add(1);
        }

        //A while loop that is repeating itself until the max number of combinations is reached.
        while (counter < Math.Pow((double)N, (double)K))
        {
            //Checking if any position in results is bigger than the max value - N. 
            //If it is, we make assign it value of 1 and increase the element in the preceding position with 1.
            for (int a = K - 1; a > 0; a--)
            {
                if (results[a] > N)
                {
                    results[a] = 1;
                    results[a - 1]++;
                }
            }

            //We are printing the current values of results.
            Console.Write("{ ");
            foreach (var item in results)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine(" }");

            //The last position in results is increased with 1 each duration.
            results[results.Count - 1]++;
            counter++;
        }
    }
}
