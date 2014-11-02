//Find obline more information about ASCII (American Standard Code for Information Interchange) and write a program
//that prints the intire ASCII table of characters on the console.

using System;

class PrintASCIITable
{
    static void Main()
    {
        //According to the info I was able to find, ASCII has been integrated into the standart UTF-8 table.
        //The numeric values of the ASCII characters can be found at http://msdn.microsoft.com/en-us/library/60ecse8t(v=vs.71).aspx
        //The chars in ASCII are originally 128 and use the decimal values of 0 to 127. Some of them are considered "control"symbols

        Console.WriteLine("Full set of ASCII characters:");
        for (byte i = 0; i < 128; i++)
        {
            Console.WriteLine("{0} : {1}", i, (char)i);
        }
    }
}
