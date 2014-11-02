namespace SampleDataSeeders
{
    using SampleDataSeeders.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CompanyEntities;

    public class ManagerSeeder : IDataSeeder
    {
        private List<int> managerIds;

        public void SeedData(CompanyEntities db)
        {
            Console.WriteLine("Seeding managers");

            //Add managers
            if (this.managerIds == null)
            {
                this.managerIds = db.Employees.Select(employee => employee.EmployeeId).ToList();
            }

            db.Configuration.AutoDetectChangesEnabled = true;
            var counter = 0;

            foreach (var employee in db.Employees)
            {
                if (Utilities.Instance.GenerateRandomInteger(1, 100) < 95)
                {
                    var managerId = GetManager(db);
                    employee.ManagerId = managerId;
                }

                if (counter % 100 == 0)
                {
                    Console.Write(".");
                }

                counter++;
            }

            db.SaveChanges();

            Console.WriteLine("Managers seeded!");
        }

        private int GetManager(CompanyEntities db)
        {
            var selectedManagerId = this.managerIds[Utilities.Instance.GenerateRandomInteger(0, this.managerIds.Count - 1)];

            return selectedManagerId;
        }
    }
}
