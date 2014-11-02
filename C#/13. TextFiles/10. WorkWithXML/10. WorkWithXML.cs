//Write a program that extracts from given XML file
//all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name>
//<age>21</age><interests count="3"><interest>
//Games</instrest><interest>C#</instrest><interest>
//Java</instrest></interests></student>

using System;
using System.IO;
using System.Xml;

class WorkWithXML
{
    static void Main()
    {
        string fileName = "file.xml";

        try
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            XmlElement element = document.DocumentElement;
            Console.WriteLine(element.InnerText);
        }
        catch (IOException a)
        {
            Console.WriteLine("An error had occured while reading the file. {0}", a.Message);
        }
        catch (XmlException b)
        {
            Console.WriteLine("There is soemthign wrogn with the XML documet. {0}", b.Message);
        }
    }
}
