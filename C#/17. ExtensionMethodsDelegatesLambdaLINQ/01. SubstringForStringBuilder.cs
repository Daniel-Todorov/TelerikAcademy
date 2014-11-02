//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Text;

public static class SubstringForStringBuilder
{
    public static StringBuilder Substring(this StringBuilder text, int index, int length)
    {
        StringBuilder result = new StringBuilder(length);
        int limit = index + length;
        for (int i = index; i < limit; i++)
        {
            result.Append(text[i]);
        }

        return result;
    }
}

class Test
{
    public static void Main()
    {
        StringBuilder test = new StringBuilder();
        test.Append("abvgdejziklmnoprst");
        StringBuilder substring = test.Substring(9, 4);
        Console.WriteLine(substring);
    }
}