//Rewrite the previous using LINQ query.

namespace _12.GetCertainAlbumsWithLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class GetCertainAlbumsWithLinq
    {
        public static void Main()
        {
            var document = XDocument.Load("Catalogue.xml");

            var prices = document.Descendants("album")
                .Where(album => int.Parse(album.Descendants("year").FirstOrDefault().Value) <= 2009)
                .Select(album => album.Descendants("price").FirstOrDefault().Value);

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}
