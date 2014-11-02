namespace XmlParsing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class BookParser
    {
        private string file;

        public BookParser(string fileToRead)
        {
            this.file = fileToRead;
        }

        public void AddBooks()
        {
            var document = XDocument.Load(this.file);

            //document.Elements
        }
    }
}
