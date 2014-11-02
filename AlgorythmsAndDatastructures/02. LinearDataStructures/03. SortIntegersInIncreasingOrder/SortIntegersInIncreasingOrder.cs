//Write a program that reads a sequence of integers 
//(List<int>) ending with an empty line and sorts 
//them in an increasing order.

using System;
using System.Collections.Generic;

class SortIntegersInIncreasingOrder
{
    static void Main()
    {
        List<int> sequence = new List<int>();

        do
        {
            try
            {
                Console.Write("Enter an integer: ");
                string rawInput = Console.ReadLine();

                if (string.IsNullOrEmpty(rawInput))
                {
                    break;
                }

                int parsedInput = int.Parse(rawInput);
                sequence.Add(parsedInput);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid number => {0} Try again.", e.Message);
            }
        }
        while (true);

        sequence.Sort();
        foreach (var number in sequence)
        {
            Console.Write("{0}, ", number);
        }
    }
}
