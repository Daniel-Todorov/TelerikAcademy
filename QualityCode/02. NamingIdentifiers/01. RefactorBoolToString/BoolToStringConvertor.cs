// Refactor the following examples to produce code with well-named C# identifiers:

// NOTE!!! I have refactored only the name identifiers as requested.
using System;

public class ConsoleWriter
{
    public const int MAX_COUNT = 6;

    public static void Main()
    {
        ConsoleWriter.BoolConsoleWriter boolConsoleWriter = new ConsoleWriter.BoolConsoleWriter();

        boolConsoleWriter.PrintBoolValue(true);
    }

    private class BoolConsoleWriter
    {
        public void PrintBoolValue(bool boolValue)
        {
            string boolAsString = boolValue.ToString();

            Console.WriteLine(boolAsString);
        }
    }
}