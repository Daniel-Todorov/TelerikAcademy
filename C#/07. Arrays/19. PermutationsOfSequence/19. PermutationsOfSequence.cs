//* Write a program that reads a number N and 
//generates and prints all the permutations of the 
//numbers [1 … N]. Example:
//n = 3 ‡ {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

//THIS PROBLEM IS MODIFICATION OF PROBLEM 20!!!
//Just like in problem 20, we are generating all possible combination of 1 to N numbers.
//Each loop rotation we check with nested for loop if all numbers inthe current combination are different.
//If they are different, we print the combination.
using System;
using System.Collections.Generic;

class PermutationsOfSequence
{
    static void Main()
    {
        int N = 0;
        int K = 0;
        int counter = 0;
        List<int> results = new List<int>();
        bool isPermutation = true;

        Console.Write("Please, type the length N of the set [1..N] and press Enter: ");
        N = int.Parse(Console.ReadLine());
        K = N;

        for (int a = 0; a < K; a++)
        {
            results.Add(1);
        }

        while (counter < Math.Pow((double)N, (double)K))
        {
            for (int a = K - 1; a > 0; a--)
            {
                if (results[a] > N)
                {
                    results[a] = 1;
                    results[a - 1]++;
                }
            }

            for (int b = 0; b < K; b++)
            {
                for (int c = b + 1; c < K; c++)
                {
                    if (results[b] == results[c])
                    {
                        isPermutation = false;
                    }
                }
            }

            if (isPermutation == true)
            {
                Console.Write("{ ");
                foreach (var item in results)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine(" }");
            }

            results[results.Count - 1]++;
            counter++;
            isPermutation = true;
        }
    }
}
