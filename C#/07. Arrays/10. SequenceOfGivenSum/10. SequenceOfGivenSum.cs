//Write a program that finds in given array of 
//integers a sequence of given sum S (if present). 
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;
using System.Collections.Generic;

class SequenceOfGivenSum
{
    static void Main()
    {
        int[] userArray;
        int arrayLength = 0;
        int maxsum = 0;
        int sum = 0;
        int counterB = 0;
        List<int> results = new List<int>();

        Console.Write("Please, type the length of the array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        userArray = new int[arrayLength];
        for (int a = 0; a < arrayLength; a++)
        {
            Console.Write("Position {0} - > ", a);
            userArray[a] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        sum = maxsum;

        Console.Write("Please, type the sum to be checked and press Enter: ");
        maxsum = int.Parse(Console.ReadLine());

        for (int a = 0; a < arrayLength; a++)
        {
            sum = maxsum - userArray[a];
            counterB = a + 1;
            results = new List<int>();
            results.Add(userArray[a]);
            while (sum > 0 && counterB < arrayLength)
            {
                sum = sum - userArray[counterB];
                if (sum >=0)
                {
                    results.Add(userArray[counterB]);
                }
                counterB++;
            }
            if (sum == 0)
            {
                foreach (var item in results)
                {
                    Console.Write("{0} ", item);
                }
                return;
            }
        }

        Console.WriteLine("There is no sequence in the array that forms the given sum.");
    }
}