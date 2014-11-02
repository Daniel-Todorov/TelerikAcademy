//* Write a program that shows the internal
//binary representation of given 32-bit signed 
//floating-point number in IEEE 754 format 
//(the C# type float). Example: -27,25 ‡ 
//sign = 1, exponent = 10000011, mantissa = 10110100000000000000000

using System;

class ShowBinaryRepresentationOfFloat
{
    static string ReverseString(string initialString)
    {
        string reversedString = null;

        for (int i = initialString.Length - 1; i >= 0; i--)
        {
            reversedString = reversedString + initialString[i];
        }

        return reversedString;
    }

    static void Main()
    {
        float initialNumber = 0.0F;
        string signBit = null;
        string exponentBits = null;
        string mantissaBits = null;
        int exponent = 0;
        int initialNumberIntegerPart = 0;
        float leftovers = 0.0F;


        Console.Write("Please, type the floating point number you want to represent in binary code and press Enter: ");
        initialNumber = float.Parse(Console.ReadLine());

        //Get the sign bit.
        if (initialNumber >= 0)
        {
            signBit = "0";
        }
        else if (initialNumber < 0)
        {
            signBit = "1";
        }

        //Get the exponent.
        //The binary reprsentation of the exponent = exponent + 127.
        //There is a difference however in the way we calculate the binary representation when the number N is -1 < N < 1.
        initialNumberIntegerPart = Math.Abs((int)initialNumber);
        if (initialNumberIntegerPart >= 1)
        {
            while (initialNumberIntegerPart > 1)
            {
                initialNumberIntegerPart = initialNumberIntegerPart / 2;
                exponent = exponent + 1;
            }
            exponent = exponent + 127;
        }
        else if (initialNumberIntegerPart == 0)
        {
            for (double i = -1; i > -128; i--)
            {
                if (Math.Abs(initialNumber) >= Math.Pow(2, i))
                {
                    exponent = (int)i + 127;
                    break;
                }
            }
        }

        //Get the binary representation of the exponent.       
        initialNumberIntegerPart = exponent;
        for (int i = 0; i < 8; i++)
        {
            exponentBits = exponentBits + initialNumberIntegerPart % 2;
            initialNumberIntegerPart = initialNumberIntegerPart / 2;
        }
        exponentBits = ReverseString(exponentBits);

        //Get the mantissa.
        float initialLeftovers = (float)Math.Pow(2, (double)exponent - 127);
        leftovers = initialLeftovers;
        for (int i = 1; i <= 23; i++)
        {
            if (leftovers + (initialLeftovers * 1 / (Math.Pow(2.0, i))) <= Math.Abs(initialNumber))
            {
                leftovers = leftovers + (float)(initialLeftovers * 1 / (Math.Pow(2.0, i)));
                mantissaBits = mantissaBits + "1";
            }
            else
            {
                mantissaBits = mantissaBits + "0";
            }
        }

        Console.WriteLine("{0} -> sign = {1}, exponent = {2}, mantissa = {3}", initialNumber, signBit, exponentBits, mantissaBits);
    }
}
