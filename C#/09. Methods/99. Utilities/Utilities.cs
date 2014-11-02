//This project holds Methods which are supposed to save time by performing routine tasks.

using System;

public class Utilities
{
    static public int[] GenerateIntegerArray()
    {
        int[] array;
        int arrayLength = 0;
        Console.Write("Please, type how much elements you want the integer array and press Enter: ");
        arrayLength = int.Parse(Console.ReadLine());
        array = new int[arrayLength];
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Position {0} - > ", i);
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        return array;
    }

    static void Main()
    {
    }
}
