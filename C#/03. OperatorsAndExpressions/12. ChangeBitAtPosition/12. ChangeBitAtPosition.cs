//We are given given integer number n, value v (v=o or 1) and position p. Write a sequence of operators 
//that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n=5 (00000101), p=3, v=1 -> (00001101)
//Example: n=5 (00000101), p=2, v=0 -> (00000001)

using System;

class ChangeBitAtPosition
{
    static void Main()
    {
        int integerNumber = 0;
        byte value = 0;
        byte position = 0;
        int mask = 1;

        Console.WriteLine("Please, type the integer number N to be changed and press Enter:");
        integerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the value V of the bit you want to change and press Enter:");
        value = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the position P in number N that you wish to be changed to value V and press Enter:");
        position = byte.Parse(Console.ReadLine());

        if (value == 1)
        {
            mask = mask << position;
            integerNumber = integerNumber | mask;
            Console.WriteLine("The number N after tranformation is {0}", integerNumber);
        }
        else
        {
            mask = mask << position;
            mask = ~mask;
            integerNumber = integerNumber & mask;
            Console.WriteLine("The number N after transformation is {0}", integerNumber);
        }
    }
}
