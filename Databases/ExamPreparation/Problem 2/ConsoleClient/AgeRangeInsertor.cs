namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToyStoreModels;

    public class AgeRangeInsertor : IEntityInsertor
    {
        private int numberOfElementsToInsert;
        private const int MinAge = 0;
        private const int MaxAge = 100;

        public AgeRangeInsertor(int numberOfElementsToInsert)
        {
            this.numberOfElementsToInsert = numberOfElementsToInsert;
        }

        public void InsertEntities(ToyStoreModels.ToyStoreEntities db)
        {
            for (int i = 0; i < this.numberOfElementsToInsert; i++)
            {
                var minAge = Utilities.Instance.GenerateRandomInteger(MinAge,MaxAge - 2);
                var maxAge = Utilities.Instance.GenerateRandomInteger(minAge + 1, MaxAge);
                var ageRange = new AgeRanx() { MinAge = minAge, MaxAge = maxAge};

                db.AgeRanges.Add(ageRange);

                if (i % 100 == 0)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
