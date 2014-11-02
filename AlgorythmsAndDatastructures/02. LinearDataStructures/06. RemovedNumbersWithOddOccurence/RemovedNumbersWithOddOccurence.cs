//Write a program that removes from given sequence 
//all numbers that occur odd number of times. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemovedNumbersWithOddOccurence
{
    static void Main()
    {
        List<int> sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        List<int> distictValues = sequence.Distinct().ToList();

        foreach (var item in distictValues)
        {
            if (sequence.Count(element => element == item) % 2 != 0)
            {
                sequence.RemoveAll(element => element == item);
            }
        }

        foreach (var item in sequence)
        {
            Console.Write("{0} ", item);
        }
    }
}
