//Write a program to compare the performance of 
//square root, natural logarithm, sinus for float, 
//double and decimal values.

using System;
using System.Diagnostics;

class CompareBuildInPerformance
{
    static void Main()
    {
        float floatNumber = 99F;
        double doubleNumber = 99.0;
        decimal decimalNumber = 99M;

        RunTests(floatNumber, "float");

        RunTests(doubleNumber, "double");

        RunTests(decimalNumber, "decimal");
    }

    private static void RunTests(dynamic number, string type)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
                Math.Sqrt((double)number);
        }
        stopwatch.Stop();
        Console.WriteLine("Sqrt for {0}: {1}", type, stopwatch.Elapsed);

        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            Math.Log((double)number);
        }
        stopwatch.Stop();
        Console.WriteLine("Log for {0}: {1}", type, stopwatch.Elapsed);

        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            Math.Sin((double)number);
        }
        stopwatch.Stop();
        Console.WriteLine("Sin for {0}: {1}", type, stopwatch.Elapsed);
    }
}