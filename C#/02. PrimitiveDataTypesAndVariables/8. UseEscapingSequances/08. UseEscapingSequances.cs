//Declare two string variables and assign them with the following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.

using System;

class UseEscapingSequances
{
    static void Main()
    {
        string quotedString = "The \"use\" of quotations causes difficulties.";
        string notQuotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("This si the quoted string: {0}", quotedString);
        Console.WriteLine("This is the @-quoted string: {0}", notQuotedString);
    }
}
