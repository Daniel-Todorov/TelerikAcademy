//Write a program that extracts from given HTML
//file its title (if available), and its body text without 
//the HTML tags. Example:
//<html>
//<head><title>News</title></head>
//<body><p><a href="http://academy.telerik.com">Telerik
//Academy</a>aims to provide free real-world practical
//training for young people who want to turn into
//skillful .NET software engineers.</p></body>
//</html>

using System;
using System.IO;
using System.Text;

class ExtractTitleAndTextFromHTML
{
    static void Main()
    {
        //The html file is external and is supposed to be located in the Debug directory of the program.
        string htmlFileName = "html.html";
        string text = null;

        try
        {
            StreamReader reader = new StreamReader(htmlFileName);
            using (reader)
            {
                text = reader.ReadToEnd();
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The html file is missing. Make sure it is in the Debug directory and that it's name is correct.");
        }

        StringBuilder textBetweenTags = new StringBuilder();
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] == '>')
            {
                i++;
                while (text[i] != '<')
                {
                    textBetweenTags.Append(text[i]);
                    i++;
                }
            }
        }

        Console.WriteLine("The title and the text between the tags is: ");
        Console.WriteLine(textBetweenTags);
    }
}
