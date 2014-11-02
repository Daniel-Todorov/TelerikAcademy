//A dictionary is stored as a sequence of text lines
//containing words and their explanations. Write a 
//program that enters a word and translates it by
//using the dictionary. 
//Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

using System;
using System.Text.RegularExpressions;

class TranslateWithDictionary
{
    static void Main()
    {
        string dictionary = ".NET – platform for applications from Microsoft\nCLR – managed execution environment for .NET\nnamespace – hierarchical organization of classes";
        
        Console.Write("Please, type a word to translate and press Enter: ");
        string wordToTranslate = Console.ReadLine();
        while (!Regex.IsMatch(dictionary, wordToTranslate + " –"))
        {
            Console.Write("This word is not in the dictionary, please, try again: ");
            wordToTranslate = Console.ReadLine();
        }

        string explanation = (Regex.Match(dictionary, wordToTranslate + @" – .*")).ToString();
        explanation = Regex.Replace(explanation,wordToTranslate + " – ", "Explanation: ");
        Console.WriteLine(explanation);
    }
}
