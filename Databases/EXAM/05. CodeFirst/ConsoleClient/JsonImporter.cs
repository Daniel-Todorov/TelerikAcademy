namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Newtonsoft.Json;

    using CarsModel;
    using JsonModels;

    public class JsonImporter
    {
        public void AddData(string directoryName, CarEntities db)
        {
            var jsonFilesContent = GetAllJsonFilesContent(directoryName);
            var convertedFilesContent = ConvertJsonFileContentToJsonModels(jsonFilesContent);

            Console.WriteLine("Start adding json data to database");
            AddDataToDatabase(convertedFilesContent, db);
            Console.WriteLine("Finsihed!");
        }

        private static void AddDataToDatabase(List<List<JsonCar>> convertedFilesContent, CarEntities db)
        {
            int counter = 0;

            foreach (var fileContent in convertedFilesContent)
            {
                foreach (var car in fileContent)
                {
                    var model = car.Model;
                    var tranmissionType = car.TransmissionType;
                    var year = car.Year;
                    var price = car.Price;

                    Manufacturer carMaker =db.Manufacturers.FirstOrDefault(manufacturer => manufacturer.Name.Equals(car.ManufacturerName));
                    if (carMaker == null)
                    {
                        carMaker = new Manufacturer() { Name = car.ManufacturerName };
                    }

                    City dealerCity = db.Cities.FirstOrDefault(city => city.Name == car.Dealer.City);
                    if (dealerCity == null)
                    {
                        dealerCity = new City() { Name = car.Dealer.City };
                    }

                    var carDealer = new Dealer() { Name = car.Dealer.Name, Cities = new HashSet<City>()};
                    carDealer.Cities.Add(dealerCity);

                    var newCar = new Car() { Model = model, Year = year, TransmissionType = tranmissionType, Price = price, Dealer = carDealer, Manufacturer = carMaker };

                    db.Cars.Add(newCar);
                    db.SaveChanges();

                    counter++;
                    if (counter % 100 == 0)
                    {
                        Console.Write(".");
                    }
                }
            }

            db.SaveChanges();
        }

        private static List<List<JsonCar>> ConvertJsonFileContentToJsonModels(List<string> jsonFilesContent)
        {
            var result = new List<List<JsonCar>>();

            foreach (var content in jsonFilesContent)
            {
                var convertedContent = JsonConvert.DeserializeObject<List<JsonCar>>(content);
                result.Add(convertedContent);
            }

            return result;
        }

        private static List<string> GetAllJsonFilesContent(string directory)
        {
            List<string> jsonFilesContent = new List<string>();
            StreamReader reader = null;

            foreach (var file in Directory.GetFiles(directory))
            {
                if (file.EndsWith(".json"))
                {
                    reader = new StreamReader(file);
                    jsonFilesContent.Add(reader.ReadToEnd());
                }
            }

            return jsonFilesContent;
        }
    }
}
