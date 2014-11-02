//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class ReturnMinimalAndMaximal
{
    static void Main()
    {
        int lengthOfSequence = 0;
        int minimal = 0;
        int maximal = 0;
        int counter =0;
        int[] sequence;

        Console.Write("Please, type how long sequence of numbers you want to evaluate and press Enter: ");
        lengthOfSequence = int.Parse(Console.ReadLine());
        sequence = new int[lengthOfSequence];

        for (; counter < lengthOfSequence; counter++)
			{
			 Console.Write("Please, type an integer number to add to the sequence and press Enter: ");
            sequence[counter] = int.Parse(Console.ReadLine());
	    }

        minimal = sequence[0];
        maximal = sequence[0];
        foreach (int i in sequence) 
        {
            if (i < minimal) 
            {
                minimal = i;
            }
            if ( i > maximal)
            {
                maximal = i;
            }
        }

        Console.WriteLine("The minimal number is {0} and the maximal number is {1}", minimal, maximal);
    }
}
