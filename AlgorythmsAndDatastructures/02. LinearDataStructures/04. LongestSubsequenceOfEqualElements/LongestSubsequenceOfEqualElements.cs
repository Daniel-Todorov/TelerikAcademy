//Write a method that finds the longest subsequence 
//of equal numbers in given List<int> and returns 
//the result as new List<int>. Write a program to 
//test whether the method works correctly.

using System;
using System.Collections.Generic;

class LongestSubsequenceOfEqualElements
{
    static void Main()
    {
        List<int> sequence = new List<int>();
        sequence.Add(1);
        sequence.Add(2);
        sequence.Add(3);
        sequence.Add(4);
        sequence.Add(5);
        sequence.Add(6);
        sequence.Add(6);
        sequence.Add(8);
        sequence.Add(9);
        sequence.Add(9);
        sequence.Add(9);

        //And to test the method
        List<int> longestSequence = GetLongestSubsequenceOfEqualElements(sequence);

        foreach (var item in longestSequence)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }

    private static List<int> GetLongestSubsequenceOfEqualElements(List<int> sequenceOfElements)
    {
        int totalnumberOfElements = sequenceOfElements.Count;
        List<int> longestSequence = new List<int>();
        int currentSequenceStartIndex = 0;
        bool isNextElementDifferent;

        for (int i = 0; i < totalnumberOfElements; i++)
        {
            if (i + 1 < totalnumberOfElements)
            {
                isNextElementDifferent = sequenceOfElements[i] != sequenceOfElements[i + 1];
            }
            else
            {
                isNextElementDifferent = true;
            }

            if (isNextElementDifferent)
            {
                bool isCurrentSequenceLongest = i - currentSequenceStartIndex + 1 > longestSequence.Count;

                if (isCurrentSequenceLongest)
                {
                    int lengthOfSequence = i + 1 - currentSequenceStartIndex;
                    longestSequence = sequenceOfElements.GetRange(currentSequenceStartIndex, lengthOfSequence);
                }

                currentSequenceStartIndex = i + 1;
            }
        }

        return longestSequence;
    }
}
