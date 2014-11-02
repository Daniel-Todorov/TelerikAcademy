//Create a program that assigns null values to an integer and to a double variables. 
//Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullValueForIntegerAndDouble
{
    static void Main()
    {
        int? nullableInteger = null;
        double? nullableDouble = null;
        Console.WriteLine("Integer variable with no value: {0}", nullableInteger);
        Console.WriteLine("Double variable with no value: {0}", nullableDouble);

        nullableInteger = null;
        nullableDouble = null;
        Console.WriteLine("Integer variable with NULL value: {0}", nullableInteger);
        Console.WriteLine("Double variable with NULL value: {0}", nullableDouble);

        nullableInteger = 3;
        nullableDouble = 9.456;
        Console.WriteLine("Nullable integer variable with added value: {0}", nullableInteger);
        Console.WriteLine("Nullable double variable with added value: {0}", nullableDouble);
    }
}
