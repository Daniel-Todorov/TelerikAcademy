namespace SampleDataSeeders
{
    using System;
    using SampleDataSeeders.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    using CompanyEntities;

    public class ProjectSeeder : IDataSeeder
    {
        private const int MinCharsProjectName = 5;
        private const int MaxCharsProjectName = 50;

        private DateTime earliestDate;
        private List<Employee> employees;
        private int numberOfRecordsToSeed;
        private Random random;

        public ProjectSeeder(int numberOfRecordsToSeed)
        {
            this.numberOfRecordsToSeed = numberOfRecordsToSeed;
            this.random = new Random();
            this.earliestDate = DateTime.Parse("2000-01-01");
        }

        public void SeedData(CompanyEntities db)
        {
            Console.WriteLine("Seeding projects");
            if (this.employees == null)
            {
                this.employees = db.Employees.ToList();
            }

            for (int i = 0; i < numberOfRecordsToSeed; i++)
            {
                var projectName = Utilities.Instance.GenerateRandomString(MinCharsProjectName, MaxCharsProjectName);
                var newProject = new Project() { Name = projectName };

                db.Projects.Add(newProject);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                }
            }

            Console.WriteLine("Projects seeded!");
            db.SaveChanges();
        }
    }
}
