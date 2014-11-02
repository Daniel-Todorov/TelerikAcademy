//Write a program that reverses the words in given
//sentence.
//Example: "C# is not C++, not PHP and not
//Delphi!" -> "Delphi not and PHP, not C++ not is
//C#!".


using System;
using System.Text;
using System.Text.RegularExpressions;

//There is something wrong with the example output. ", not" is considered a word, which is not quite plausible.
//If there should be ",", its place is between "C++" and "not", and not between "PHP" and "not".
class ReverseWordsInSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string endSign = text[text.Length - 1].ToString() ;
        text = text.Remove(text.Length - 1);
        string[] words = text.Split(' ');
        Array.Reverse(words);

        StringBuilder reversed = new StringBuilder();
        for (int i = 0; i < words.Length - 1; i++)
        {
            reversed.Append(words[i]);
            reversed.Append(" ");
        }
        reversed.Append(words[words.Length - 1]);
        reversed.Append(endSign);

        Console.WriteLine(reversed);
    }
}
