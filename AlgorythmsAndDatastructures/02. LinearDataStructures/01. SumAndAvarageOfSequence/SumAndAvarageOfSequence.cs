//Write a program that reads from the console a 
//sequence of positive integer numbers. The sequence 
//ends when empty line is entered. Calculate and print 
//the sum and average of the elements of the 
//sequence. Keep the sequence in List<int>.


using System;
using System.Collections.Generic;

class SumAndAvarageOfSequence
{
    static void Main()
    {
        List<int> sequence = new List<int>();

        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input))
        {
            try
            {
                int inputAsInteger = int.Parse(input);

                if (inputAsInteger >= 0)
                {
                    sequence.Add(inputAsInteger);
                    Console.Write("Enter number: ");
                }
                else
                {
                    throw new ArgumentException("The nmber must be positive integer");
                }

            }
            catch (Exception)
            {
                Console.Write("Invalid number. Try Again: ");
            }

            input = Console.ReadLine();
        }

        Console.WriteLine("Sum of the elements: {0}", SumElements(sequence));
        Console.WriteLine("Avarage of the elements: {0}", GetAvarageValue(sequence));
    }

    private static double GetAvarageValue(List<int> elements)
    {
        double numberOfElements = elements.Count;
        double sumOfElements = SumElements(elements);
        double avarageValue = sumOfElements / numberOfElements;

        return avarageValue;
    }

    private static int SumElements(List<int> elements)
    {
        int sum = 0;
        foreach (var element in elements)
        {
            sum += element;
        }

        return sum;
    }
}
