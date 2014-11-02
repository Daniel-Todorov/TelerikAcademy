//Write a program that removes from given sequence 
//all negative numbers.

using System;
using System.Collections.Generic;
using System.Linq;
class RemoveNegativeNumbersFromSequence
{
    static void Main()
    {
        List<int> sequence = new List<int>();
        sequence.Add(1);
        sequence.Add(-2);
        sequence.Add(3);
        sequence.Add(-4);
        sequence.Add(5);
        sequence.Add(-67);
        sequence.Add(6);
        sequence.Add(-8);
        sequence.Add(9);
        sequence.Add(-90);
        sequence.Add(-91);

        List<int> sequenceOfPositiveElements = sequence.Where(element => element >= 0).ToList();

        foreach (var item in sequenceOfPositiveElements)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}
