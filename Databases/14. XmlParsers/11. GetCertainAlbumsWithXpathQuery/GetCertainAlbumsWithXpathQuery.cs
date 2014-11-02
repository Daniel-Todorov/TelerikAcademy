//Write a program, which extract from the file 
//catalog.xml the prices for all albums, published 5 
//years ago or earlier. Use XPath query.

//NOTE!!! The Catalogue.xml file is in the debug directory.
//It is modified to have two albums before 2010.

namespace _11.GetCertainAlbumsWithXpathQuery
{
    using System;
    using System.Xml.XPath;

    public class GetCertainAlbumsWithXpathQuery
    {
        public static void Main()
        {
            
            XPathDocument docNav = new XPathDocument("Catalogue.xml");
            XPathNavigator nav =docNav.CreateNavigator();
            string strExpression = "/catalogue/album[year<2010]/price";

            var prices = nav.Select(strExpression);

            while (prices.MoveNext())
            {
                Console.WriteLine(prices.Current.Value);
            }
        }
    }
}
