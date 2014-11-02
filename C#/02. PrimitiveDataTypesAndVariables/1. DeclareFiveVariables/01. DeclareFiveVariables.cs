//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class DeclareFiveVariables
{
    static void Main()
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        byte forthNumber = 97;
        short fifthNumber = -10000;

        Console.WriteLine("{0} can be ushort, {1} can be sbyte, {2} can be int, {3} can be byte and {4} can be short", firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber);
    }
}

