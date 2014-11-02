//Write a program to compare the performance of 
//add, subtract, increment, multiply, divide for int, 
//long, float, double and decimal values.

using System;
using System.Diagnostics;

class CompareArithmeticPerformance
{
    static void Main()
    {
        int integer = 1;
        long longInteger = 1;
        float floatNumber = 1F;
        double doubleNumber = 1.0;
        decimal decimalNumber = 1.0M;

        RunTests(integer, "Integer");

        RunTests(longInteger, "LongInteger");

        RunTests(floatNumber, "FloatNumber");

        RunTests(doubleNumber, "DoubleNumber");

        RunTests(decimalNumber, "DecimalNumber");
    }

    private static void RunTests(dynamic initialNumber, string type){
        Stopwatch stopwatch = new Stopwatch();
        dynamic number = initialNumber;

        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            number = number + 1;
        }
        stopwatch.Stop();
        Console.WriteLine("{0} adding performance: {1}", type, stopwatch.Elapsed);

        number = initialNumber;
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            number = number - 1;
        }
        stopwatch.Stop();
        Console.WriteLine("{0} substraction performance: {1}", type, stopwatch.Elapsed);

        number = initialNumber;
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            number++;
        }
        stopwatch.Stop();
        Console.WriteLine("{0} increment performance: {1}", type, stopwatch.Elapsed);

        number = initialNumber;
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            number = number * 1;
        }
        stopwatch.Stop();
        Console.WriteLine("{0} multiply performance: {1}", type, stopwatch.Elapsed);

        number = initialNumber;
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            number = number / 1;
        }
        stopwatch.Stop();
        Console.WriteLine("{0} divide performance: {1}", type, stopwatch.Elapsed);
    }
}
