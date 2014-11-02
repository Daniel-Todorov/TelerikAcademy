//Using Visual Studio generate an XSD schema for the 
//file catalog.xml. Write a C# program that takes an 
//XML file and an XSD file (schema) and validates the 
//XML file against the schema. Test it with valid XML 
//catalogs and invalid XML catalogs.

namespace _16.ValidateWithXsd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class ValidateWithXsd
    {
        public static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "Catalogue.xsd");

            XDocument vadiDocument = XDocument.Load("Catalogue.xml");
            bool errors = false;

            vadiDocument.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            Console.WriteLine("First document is {0} valid", errors ? "not" : "");

            //--------------------------------------------------------------

            schemas = new XmlSchemaSet();
            schemas.Add("", "Catalogue.xsd");

            XDocument invalidDocument = XDocument.Load("Catalogue - Copy.xml");
            errors = false;

            invalidDocument.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            Console.WriteLine("Second document is {0} valid", errors ? "not" : "");
        }
    }
}
