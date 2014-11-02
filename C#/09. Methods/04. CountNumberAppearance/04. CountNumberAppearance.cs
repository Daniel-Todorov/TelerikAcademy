//Write a method that counts how many times 
//given number appears in given array. Write a 
//test program to check if the method is working 
//correctly.

using System;

public class CountNumberAppearance
{
    public static int Counter(int[] array, int givenNumber)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == givenNumber)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main()
    {
        int[] array = Utilities.GenerateIntegerArray();
        int givenNumber = 0;
        int counter = 0;

        Console.Write("Please, type the integer number to check for and press Enter: ");
        givenNumber = int.Parse(Console.ReadLine());

        counter = Counter(array, givenNumber);

        Console.WriteLine("Number {0} repeats {1} times in the array!", givenNumber, counter);
    }
}
