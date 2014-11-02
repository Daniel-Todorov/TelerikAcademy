namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToyStoreModels;

    public class CategoryInsertor : IEntityInsertor
    {
        private int numberOfElementsToInsert;

        public CategoryInsertor(int numberOfElementsToInsert)
        {
            this.numberOfElementsToInsert = numberOfElementsToInsert;
        }

        public void InsertEntities(ToyStoreModels.ToyStoreEntities db)
        {
            for (int i = 0; i < this.numberOfElementsToInsert; i++)
            {
                var categoryName = Utilities.Instance.GenerateRandomString(5, 10);
                var newCategory = new Category() { Name = categoryName };

                db.Categories.Add(newCategory);

                if (i % 100 == 0)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
