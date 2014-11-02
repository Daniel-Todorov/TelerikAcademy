//Using JSON.NET and the Telerik Academy Forums RSS 
//feed implement the following:
//1. The RSS feed is at http://forums.academy.telerik.com/feed/qa.rss
//2. Download the content of the feed programmatically
// You can use WebClient.DownloadFile()
//3. Parse the XML from the feed to JSON
//4. Using LINQ-to-JSON select all the question titles and print them to the console
//5. Parse the JSON string to POCO
//6. Using the parsed objects create a HTML page that 
//lists all questions from the RSS their categories and 
//a link to the question's page.

namespace _15.JsonParsers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using JsonModels;

    public class TelerikRSS
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            XDocument xmlRss = GetRSSFromURL("http://forums.academy.telerik.com/feed/qa.rss");
            string jsonRss = XmlToJsonRss(xmlRss);
            JObject jObject = JObject.Parse(jsonRss);
            var questionTitles = jObject["rss"]["channel"]["item"].Select(item => item["title"]).ToList();

            PrintQuestionTitles(questionTitles);

            var items = JsonConvert.DeserializeObject<List<Item>>( jObject["rss"]["channel"]["item"].ToString());

            string htmlContent = GenerateHtml(items);
            CreateHtmlFile(htmlContent);
        }

        private static void CreateHtmlFile(string htmlContent)
        {
            StreamWriter writer = new StreamWriter("TelerikRSS.html");

            using (writer)
            {
                writer.Write(htmlContent);
            }
        }

        private static string GenerateHtml(IEnumerable<Item> items)
        {
            StringBuilder result = new StringBuilder();
            result.Append("<!DOCTYPE html><html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\"><head><meta charset=\"utf-8\" /><title>Telerik RSS</title></head><body>");

            foreach (var item in items)
            {
                result.Append("<section>");
                result.Append("<h1>" + item.Title + "</h1>");
                result.Append("<h3>Category: " + item.Category + "</h3>");
                result.Append(item.Description);
                result.Append("<a href=\"" + item.Link + "\">Link</a>");
                result.Append("</section>");
            }

            result.Append("</body></html>");

            return result.ToString();
        }

        private static void PrintQuestionTitles(IEnumerable<JToken> titles)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var index = 1;

            foreach (var title in titles)
            {
                Console.WriteLine("{0}. {1}{2}", index, title, Environment.NewLine);
                index++;
            }
        }

        private static string XmlToJsonRss(XDocument xmlRss)
        {
            return JsonConvert.SerializeXNode(xmlRss);
        }

        private static XDocument GetRSSFromURL(string url)
        {
            var webClient = new WebClient();
            webClient.DownloadFile(url, "rss.xml");

            XDocument xmlRss = XDocument.Load("rss.xml");

            return xmlRss;
        }
    }
}
