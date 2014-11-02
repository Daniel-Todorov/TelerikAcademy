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

    public class EmployeeSeeder : IDataSeeder
    {
        private const int MinCharLengthOfName = 5;
        private const int MaxcharLengthOfName = 20;
        private const int MinSalary = 50000;
        private const int MaxSalary = 200000;

        private int numberOfRecordsToSeed;
        private List<int> departmentIds;

        public EmployeeSeeder(int numberOfRecordsToSeed)
        {
            this.numberOfRecordsToSeed = numberOfRecordsToSeed;
        }

        public void SeedData(CompanyEntities db)
        {
            Console.WriteLine("Seeding employees");

            if (this.departmentIds == null)
            {
                this.departmentIds = db.Departments.Select(department => department.DepartmentId).ToList();
            }

            for (int i = 0; i < numberOfRecordsToSeed; i++)
            {
                string firstName = Utilities.Instance.GenerateRandomString(MinCharLengthOfName, MaxcharLengthOfName);
                string lastName = Utilities.Instance.GenerateRandomString(MinCharLengthOfName, MaxcharLengthOfName);
                int salary = Utilities.Instance.GenerateRandomInteger(MinSalary, MaxSalary);
                int departmentId = GetDepartmentId(db);

                var newEmployee = new Employee() { FirstName = firstName, LastName = lastName, YearSalary = salary, DepartmentId = departmentId };

                db.Employees.Add(newEmployee);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                }
            }

            db.SaveChanges();

            Console.WriteLine("Employees seeded");
        }

        private int GetDepartmentId(CompanyEntities db)
        {
            var selectedDepartmentId = this.departmentIds[Utilities.Instance.GenerateRandomInteger(0, this.departmentIds.Count - 1)];

            return selectedDepartmentId;
        }
    }
}
