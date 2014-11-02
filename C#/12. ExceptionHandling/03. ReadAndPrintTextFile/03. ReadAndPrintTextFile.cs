//Write a program that enters file name along with its
//full file path (e.g. C:\WINDOWS\win.ini), reads its 
//contents and prints it on the console. Find in MSDN
//how to use System.IO.File.ReadAllText(…). Be 
//sure to catch all possible exceptions and print 
//userfriendly error messages.

using System;
using System.IO;
using System.Security;

class ReadAndPrintTextFile
{
    static void Main()
    {
        string filePath = @"C:\WINDOWS\win.ini";
        string text = null;

        try
        {
            text = File.ReadAllText(filePath);
            Console.WriteLine(text);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path is a null value string.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The path is a zero-length string, contains only white space, or contains one or more invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. On Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid. It may be on an unmapped drive).");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The path specified a file that is read-only or this operation is not supported on the current platform. It is also posible that the path specified a directory or the caller does not have the required permission.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}