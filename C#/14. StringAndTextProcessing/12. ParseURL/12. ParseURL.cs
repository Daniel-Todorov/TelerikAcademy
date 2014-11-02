//Write a program that parses an URL address
//given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server]
//and [resource] elements. For example from the 
//URL http://www.devbg.org/forum/index.php 
//the following information should be 
//extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        string protocol = (Regex.Match(url, @"\w.*?://")).ToString();
        protocol = protocol.TrimEnd(':', '/');
        Console.WriteLine("The protocol is: {0}", protocol);
        string server = (Regex.Match(url, @"://.*?/")).ToString();
        server = server.Trim(':', '/');
        Console.WriteLine("The server is: {0}", server);
        string resource = (Regex.Match(url, @"\w/.*\w")).ToString();
        resource = resource.Remove(0, 1);
        Console.WriteLine("The resource is: {0}", resource);
    }
}
