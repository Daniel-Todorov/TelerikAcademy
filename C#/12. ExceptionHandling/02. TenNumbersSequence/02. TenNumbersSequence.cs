//Write a method ReadNumber(int start, int
//end) that enters an integer number in given 
//range [start…end]. If an invalid number or 
//nonnumber text is entered, the method should throw 
//an exception. Using this method write a program 
//that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class TenNumbersSequence
{
    static int ReadNumber(int start, int end)
    {
        int number = 0;

        while (number == 0)
        {
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number <= start || number >= end)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.Write("This is either not a number or is not in the specified value range. Please, try again: ");
                number = 0;
            }
        }

        return number;
    }

    static void Main()
    {
        int start = 1; //Defined in the according to the condition of the assignment.
        int end = 91; //If the initial end index is 100, then we can't have 10 different numbers that satisfy the condition of the task.
        int[] sequence = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Please, type number a{0} [ {1} < a{0} < {2} ] and press Enter: ", i + 1, start, end);
            sequence[i] = ReadNumber(start, end);
            start = sequence[i];
            end++;
        }

        for (int i = 0; i < sequence.Length; i++)
        {
            Console.Write("{0} ",sequence[i]);
        }
    }
}