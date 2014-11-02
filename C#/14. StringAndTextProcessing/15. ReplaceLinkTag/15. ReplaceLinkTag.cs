//Write a program that replaces in a HTML
//document given as string all the tags <a 
//href="…">…</a> with corresponding tags 
//[URL=…]…/URL]. Sample HTML fragment:
//<p>Please visit <a href="http://academy.telerik.com">
//our site</a> to choose a training course. Also
//visit <a href="www.devbg.org">our forum</a> to
//discuss the courses.</p>
//<p>Please visit [URL=http://academy.telerik.com]
//our site[/URL] to choose a training course. Also
//visit [URL=www.devbg.org]our forum[/URL] to discuss
//the courses.</p>

using System;
using System.Text.RegularExpressions;

class ReplaceLinkTag
{
    static void Main()
    {
        string html = "<p>Please visit <a href=\"http://academy.telerik.com\"> our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string htmlWithoutClosingTags = Regex.Replace(html, "</a>", "[/URL]");
        string htmlWithoutOpeningTags = Regex.Replace(htmlWithoutClosingTags, "<a href=\"", "[URL=");
        string htmlWithoutAnyTags = Regex.Replace(htmlWithoutOpeningTags, "\">", "]");

        Console.WriteLine("The text with changed tags is: ");
        Console.WriteLine(htmlWithoutAnyTags);
    }
}
