//Modify the solution of the previous problem to
//replaceonly whole words (not substrings).

using System;
using System.IO;
using System.Text;

class ReplaceWordsInTextFile
{

    static void Main()
    {
        string fileName = "fileToChange.txt";
        string text = null;
        string initial = "start";
        string morphedInitial = null;
        string changeTo = "finish";
        string morphedChangedTo = null;

        try
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                text = reader.ReadToEnd();
            }
        }
        catch (IOException a)
        {
            Console.WriteLine("An error occured while reading the file. {0}", a.Message);
        }

        morphedInitial = " " + initial + " ";
        morphedChangedTo = " " + changeTo + " ";
        text = text.Replace(morphedInitial, morphedChangedTo);

        morphedInitial = " " + initial + ".";
        morphedChangedTo = " " + changeTo + ".";
        text = text.Replace(morphedInitial, morphedChangedTo);

        morphedInitial = " " + initial + ",";
        morphedChangedTo = " " + changeTo + ",";
        text = text.Replace(morphedInitial, morphedChangedTo);

        morphedInitial = " " + initial + "!";
        morphedChangedTo = " " + changeTo + "!";
        text = text.Replace(morphedInitial, morphedChangedTo);

        morphedInitial = " " + initial + "?";
        morphedChangedTo = " " + changeTo + "?";
        text = text.Replace(morphedInitial, morphedChangedTo);

        morphedInitial = " " + initial + ";";
        morphedChangedTo = " " + changeTo + ";";
        text = text.Replace(morphedInitial, morphedChangedTo);

        try
        {
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.Write(text);
            }
        }
        catch (IOException b)
        {
            Console.WriteLine("An error occured while writing the file. {0}", b.Message);
        }

        Console.WriteLine("It is done!");
    }
}