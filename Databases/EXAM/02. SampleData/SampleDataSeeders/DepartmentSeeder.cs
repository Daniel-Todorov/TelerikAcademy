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

    public class DepartmentSeeder: IDataSeeder
    {
        private const int MinCharLengthOfDepartment = 10;
        private const int MaxcharLengthOfDepartment = 50;

        private int numberOfRecordsToSeed;

        public DepartmentSeeder(int numberOfRecordsToSeed)
        {
            this.numberOfRecordsToSeed = numberOfRecordsToSeed;
        }

        public void SeedData(CompanyEntities db)
        {
            string newDepartmentName = string.Empty;

            for (int i = 0; i < this.numberOfRecordsToSeed; i++)
            {
                while (true)
                {
                    newDepartmentName = Utilities.Instance.GenerateRandomString(MinCharLengthOfDepartment, MaxcharLengthOfDepartment);

                    if (!db.Departments.Any(department => department.Name.Equals(newDepartmentName)))
                    {
                        break;
                    }
                    else
                    {
                        newDepartmentName = Utilities.Instance.GenerateRandomString(MinCharLengthOfDepartment, MaxcharLengthOfDepartment);
                    }
                }

                var newDepartment = new Department() { Name = newDepartmentName };

                db.Departments.Add(newDepartment);

                if (i % 100 == 0)
                {
                    db.SaveChanges();
                }
            }

            db.SaveChanges();
        }
    }
}
