namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToyStoreModels;

    public class ManufacturerInsertor : IEntityInsertor
    {
        private int numberOfElementsToAdd;

        public ManufacturerInsertor(int numberOfElementsToAdd)
        {
            this.numberOfElementsToAdd = numberOfElementsToAdd;
        }

        public void InsertEntities(ToyStoreEntities db)
        {
            for (int i = 0; i < this.numberOfElementsToAdd; i++)
            {
                var country = Utilities.Instance.GenerateRandomString(10, 20);
                var name = Utilities.Instance.GenerateRandomString(5, 10);
                while (db.Manufacturers.Any(manufacturer => manufacturer.Name.Equals(name)))
                {
                    name = Utilities.Instance.GenerateRandomString(5, 10);
                }
                var newManufacturer = new Manufacturer() { Name = name, Country = country };
                db.Manufacturers.Add(newManufacturer);

                if (i % 100 >= 0)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
