//Write a program that finds in given array of integers 
//(all belonging to the range [0..1000]) how many 
//times each of them occurs.

using System;
using System.Collections.Generic;
using System.Linq;

class FindNumberOfOccurences
{
    static void Main()
    {
        int[] sequence = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        List<int> distictNumbers = sequence.Distinct().ToList();

        foreach (var distinctNumber in distictNumbers)
        {
            int numberOfOccurences = sequence.Count(element => element == distinctNumber);

            Console.WriteLine("{0} => {1} times", distinctNumber, numberOfOccurences);
        }
    }
}
