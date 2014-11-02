namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ToyStoreModels;

    public class ConsoleClient
    {
        public static void Main()
        {
            var db = new ToyStoreEntities();
            db.Configuration.AutoDetectChangesEnabled = false;

            List<IEntityInsertor> insertors = new List<IEntityInsertor>();
            insertors.Add(new AgeRangeInsertor(100));
            insertors.Add(new CategoryInsertor(100));
            insertors.Add(new ManufacturerInsertor(50));
            insertors.Add(new ToyInsertor(20000));

            foreach (var insertor in insertors)
            {
                insertor.InsertEntities(db);
            }

            db.SaveChanges();
        }
    }
}
