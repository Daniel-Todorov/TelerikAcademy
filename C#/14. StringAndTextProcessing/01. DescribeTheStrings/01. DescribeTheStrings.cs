//Describe the strings in C#. What is typical for the
//string data type? Describe the most important 
//methods of the String class.

using System;

class DescribeTheStrings
{
    static void Main()
    {
        Console.WriteLine("  A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0'). The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters.");
        Console.WriteLine();
        Console.WriteLine("  In C#, the string keyword is an alias for String. Therefore, String and string are equivalent, and you can use whichever naming convention you prefer. The String class provides many methods for safely creating, manipulating, and comparing strings. In addition, the C# language overloads some operators to simplify common string operations. For more information about the keyword, see string (C# Reference). For more information about the type and its methods, see String.");
        Console.WriteLine();
        Console.WriteLine("  String objects are immutable: they cannot be changed after they have been created. All of the String methods and C# operators that appear to modify a string actually return the results in a new string object. In the following example, when the contents of s1 and s2 are concatenated to form a single string, the two original strings are unmodified. The += operator creates a new string that contains the combined contents. That new object is assigned to the variable s1, and the original object that was assigned to s1 is released for garbage collection because no other variable holds a reference to it.");
        Console.WriteLine("  Because a string \"modification\" is actually a new string creation, you must use caution when you create references to strings. If you create a reference to a string, and then \"modify\" the original string, the reference will continue to point to the original object instead of the new object that was created when the string was modified.");
        Console.WriteLine();
        Console.WriteLine("  A format string is a string whose contents can be determined dynamically at runtime. You create a format string by using the static Format method and embedding placeholders in braces that will be replaced by other values at runtime.");
        Console.WriteLine();
        Console.WriteLine("  One overload of the WriteLine method takes a format string as a parameter. Therefore, you can just embed a format string literal without an explicit call to the method. However, if you use the WriteLine method to display debug output in the Visual Studio Output window, you have to explicitly call the Format method because WriteLine only accepts a string, not a format string.");
        Console.WriteLine();
        Console.WriteLine("  A substring is any sequence of characters that is contained in a string. Use the Substring method to create a new string from a part of the original string. You can search for one or more occurrences of a substring by using the IndexOf method. Use the Replace method to replace all occurrences of a specified substring with a new string. Like the Substring method, Replace actually returns a new string and does not modify the original string.");
        Console.WriteLine();
        Console.WriteLine("  Because the String type implements IEnumerable<T>, you can use the extension methods defined in the Enumerable class on strings. To avoid visual clutter, these methods are excluded from IntelliSense for the String type, but they are available nevertheless. You can also use LINQ query expressions on strings.");
    }
}