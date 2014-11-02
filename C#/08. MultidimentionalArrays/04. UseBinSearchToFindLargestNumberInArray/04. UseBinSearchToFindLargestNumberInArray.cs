//Write a program, that reads from the console an 
//array of N integers and an integer K, sorts the 
//array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;

class UseBinSearchToFindLargestNumberInArray
{
    static void Main()
    {
        int N = 0;
        int K = 0;
        int[] array;
        int positionK = 0;

        Console.Write("Please, type the length N of the array and press Enter: ");
        N = int.Parse(Console.ReadLine());
        Console.Write("Please, type the integer K and press Enter: ");
        K = int.Parse(Console.ReadLine());
        array = new int[N];
        Console.WriteLine();
        for (int i = 0; i < N; i++)
        {
            Console.Write("Array {0} -> ", i);
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Array.Sort(array);

        positionK = Array.BinarySearch(array, K);

        if (positionK >= 0)
        {
            Console.WriteLine("The largest number in the array <= K is {0} and is located in position {1}.", array[positionK], positionK);
        }
        else if (positionK < 0)
        {
            Console.WriteLine("The largest number in the array <=K is {0} and is located in position {1}.", array[positionK * (-1) - 2], positionK * (-1) - 2);
        }
    }
}
