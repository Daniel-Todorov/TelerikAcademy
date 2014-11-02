namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ToyStoreModels;

    public class ToyInsertor :IEntityInsertor 
    {
        private int numberOfElementsToAdd;

        public ToyInsertor(int numberOfElementsToAdd)
        {
            this.numberOfElementsToAdd = numberOfElementsToAdd;
        }

        public void InsertEntities(ToyStoreEntities db)
        {
            for (int i = 0; i < this.numberOfElementsToAdd; i++)
            {
                var name = Utilities.Instance.GenerateRandomString(5, 10);
                var type = Utilities.Instance.GenerateRandomString(5, 10);

                var numberOfManufacturers = db.Manufacturers.Count();
                var selectedManufacturer = db.Manufacturers.Select(manufacturer => manufacturer.Id).ToList()[Utilities.Instance.GenerateRandomInteger(0, numberOfManufacturers - 1)];
                
                var price = Utilities.Instance.GenerateRandomPrice(0, 100);
                var color = Utilities.Instance.GenerateRandomString(5, 10);

                var numberOfAgeRanges = db.AgeRanges.Count();
                var selectedAgeRange = db.AgeRanges.Select(ageRange => ageRange.Id).ToList()[Utilities.Instance.GenerateRandomInteger(0, numberOfAgeRanges - 1)];

                var toy = new Toy() { Name = name, Type = type, Manufacturer = selectedManufacturer, Price = price, Color = color, AgeRange = selectedAgeRange };

                var numberOfCategories = Utilities.Instance.GenerateRandomInteger(1, 3);
                var categoryIds = db.Categories.Select(category => category.Id).ToList();
                var selectedCategories = new HashSet<int>();
                while (selectedCategories.Count < numberOfCategories)
                {
                    selectedCategories.Add(categoryIds[Utilities.Instance.GenerateRandomInteger(0, categoryIds.Count - 1)]);
                }
                foreach (var id in selectedCategories)
                {
                    toy.Categories.Add(db.Categories.Find(id));
                }

                db.Toys.Add(toy);

                if (i % 100 == 0)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
