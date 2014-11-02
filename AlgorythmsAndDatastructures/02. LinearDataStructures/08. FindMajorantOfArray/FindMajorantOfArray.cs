// * The majorant of an array of size N is a value that 
//occurs in it at least N/2 + 1 times. Write a program to 
//find the majorant of given array (if exists). 

using System;
using System.Collections.Generic;
using System.Linq;

class FindMajorantOfArray
{
    static void Main()
    {
        int[] sequence = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

        int numberOfElements = sequence.Length;
        double neededNumberOfOccurences = numberOfElements / 2 + 1;
        List<int> distinctNumbers = sequence.Distinct().ToList();

        foreach (var number in distinctNumbers)
        {
            if (sequence.Count(element => element == number) >= neededNumberOfOccurences)
            {
                Console.WriteLine("The majorant of the array is: {0}", number);
                return;
            }
        }

        Console.WriteLine("There is no majorant in the array");
    }
}
