//Write a method that checks if the element at given 
//position in given array of integers is bigger than its 
//two neighbors (when such exist).

using System;

public class CheckNearbyElements
{
    public static bool CheckNeighbourElements(int[] array, int index)
    {
        bool isBiggerThanNeighbours = false;

        if (index > 0 && index < array.Length - 1)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                isBiggerThanNeighbours = true;
            }
        }

        return isBiggerThanNeighbours;
    }

    static void Main()
    {
        int[] userArray = Utilities.GenerateIntegerArray();
        int position = 0;

        Console.Write("Please, type the position of the element to be checked and press Enter: ");
        position = int.Parse(Console.ReadLine());

        if (CheckNeighbourElements(userArray,position))
        {
            Console.WriteLine("The element with index {0} is bigger than both of its neighbours!", position);
        }
        else
        {
            Console.WriteLine("The element with index {0} is not bigger than both of its neighbours or has only one neighbour!", position);
        }
    }
}
