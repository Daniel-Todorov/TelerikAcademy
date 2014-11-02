using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wintellect.PowerCollections;

namespace _03.OnlineMarket
{
    class OnlineMarket
    {
        private static StringBuilder output = new StringBuilder();
        private static Dictionary<string, Product> products = new Dictionary<string, Product>();

        static void Main()
        {
            var commands = new Queue<string>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                commands.Enqueue(command);
            }

            while (commands.Count > 0)
            {
                var command = commands.Dequeue();

                if (command.StartsWith("add"))
                {
                    AddProduct(command);
                }
                else if (command.StartsWith("filter by type"))
                {
                    FilterByType(command);
                }
                else if (command.StartsWith("filter by price"))
                {
                    FilterByPrice(command);
                }
                else if (command.StartsWith(""))
                {

                }
            }

            Console.WriteLine(output);
        }

        private static void FilterByPrice(string command)
        {
            double minPrice = 0.0;
            double maxPrice = 0.0;
            if (command.Contains("to") && !command.Contains("from"))
            {
                minPrice = double.MinValue;
                maxPrice = double.Parse(command.Substring(19));
            }
            else if (!command.Contains("to") && command.Contains("from"))
            {
                minPrice = double.Parse(command.Substring(21));
                maxPrice = double.MaxValue;
            }
            else if (command.Contains("to") && command.Contains("from"))
            {
                var priceRanges = command.Substring(21).Split(new string[] { " to " }, StringSplitOptions.RemoveEmptyEntries);
                minPrice = double.Parse(priceRanges[0]);
                maxPrice = double.Parse(priceRanges[1]);
            }

            var results = products
                .Where(product => minPrice <= product.Value.Price && product.Value.Price <= maxPrice)
                .OrderBy(product => product.Value.Price)
                .ThenBy(product => product.Value.Name)
                .ThenBy(product => product.Value.Type).Take(10).ToList();

            if (results.Count > 0)
            {
                string listOfProducts = string.Join(", ", results.Select(product => string.Format("{0}({1})", product.Value.Name, product.Value.Price)).ToArray());
                output.AppendLine(string.Format("Ok: {0}", listOfProducts));
            }
            else if (results.Count <= 0)
            {
                output.AppendLine("Ok: ");
            }

            //var result = productsByPrice.Range(minPrice, true, maxPrice, true);

            //if (result.Count > 0)
            //{
            //    var counter = 0;
            //    string[] listOfProducts = new string[10];

            //    foreach (var prods in result)
            //    {
            //        foreach (var item in prods.Value)
            //        {
            //            if (counter >= 10)
            //            {
            //                break;
            //            }

            //            counter++;
            //            listOfProducts[counter] = string.Format("{0}({1})", item.Name, item.Price);
            //        }

            //        if (counter >= 10)
            //        {
            //            break;
            //        }
                    
            //    }

            //    output.AppendLine(string.Format("Ok: {0}", string.Join(", ", listOfProducts)));
            //}
            //else
            //{
            //    output.AppendLine("Ok: ");
            //}
        }

        private static void FilterByType(string command)
        {
            var type = command.Substring(15);
            var results = products
                .Where(product => product.Value.Type == type)
                .OrderBy(product => product.Value.Price)
                .ThenBy(product => product.Value.Name)
                .ThenBy(product => product.Value.Type).Take(10).ToList();


            if (results.Count > 0)
            {
                string listOfProducts = string.Join(", ", results.Select(product => string.Format("{0}({1})", product.Value.Name, product.Value.Price)).ToArray());
                output.AppendLine(string.Format("Ok: {0}", listOfProducts));
            }
            else if (results.Count <= 0)
            {
                output.AppendLine(string.Format("Error: Type {0} does not exists", type));
            }
        }

        private static void AddProduct(string command)
        {
            var splitedCommand = command.Split(' ');
            var name = splitedCommand[1];

            if (products.ContainsKey(name))
            {
                output.AppendLine(string.Format("Error: Product {0} already exists", name));
                return;
            }

            var price = double.Parse(splitedCommand[2]);
            var type = splitedCommand[3];

            

            products.Add(name, new Product() { Name = name, Price = price, Type = type });
            output.AppendLine(string.Format("Ok: Product {0} added successfully", name));
        }
    }

    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public int CompareTo(object obj)
        {
            var objectToCompare = obj as Product;

            if (objectToCompare.Price > this.Price)
            {
                return -1;
            }
            else if (objectToCompare.Price < this.Price)
            {
                return 1;
            }
            else if (objectToCompare.Name != this.Name)
            {
                return this.Name.CompareTo(objectToCompare.Name);
            }
            else if (this.Type != objectToCompare.Type)
            {
                return this.Type.CompareTo(objectToCompare.Type);
            }
            else
            {
                return 0;
            }
        }
    }
}
