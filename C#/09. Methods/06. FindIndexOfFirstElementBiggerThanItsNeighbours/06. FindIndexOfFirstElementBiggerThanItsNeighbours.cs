//Write a method that returns the index of the first 
//element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FindIndexOfFirstElementBiggerThanItsNeighbours
{
    static int FindIndex(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            if (CheckNearbyElements.CheckNeighbourElements(array, i))
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] intArray = Utilities.GenerateIntegerArray();
        int index = 0;

        index = FindIndex(intArray);

        if (index >= 0)
        {
            Console.WriteLine("The index of the first element in the array that is bigger than its neighbours is {0}!", index);
        }
        else
        {
            Console.WriteLine("The is no element in the array which is bigger than its neighbours!");
        }      
    }
}