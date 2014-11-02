namespace SampleDataSeeders
{
    using SampleDataSeeders.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CompanyEntities;

    public class ReportSeeder : IDataSeeder
    {
        private int minNumberOfRecords = 5;
        private int maxNumberOfRecords = 20;
        private List<int> employeeIds;

        public ReportSeeder(int minNumberOfRecords, int maxNumberOfRecords)
        {
            this.minNumberOfRecords = minNumberOfRecords;
            this.maxNumberOfRecords = maxNumberOfRecords;
        }

        public void SeedData(CompanyEntities db)
        {
            Console.WriteLine("Seeding reports");

            if (this.employeeIds == null)
            {
                this.employeeIds = db.Employees.Select(employee => employee.EmployeeId).ToList();
            }

            var counter = 0;
            foreach (var id in employeeIds)
            {
                AddReports(db, id);

                if (counter % 100 == 0)
                {
                    Console.Write(".");
                }

                counter++;
            }

            Console.WriteLine("Reports seeded");
        }

        private void AddReports(CompanyEntities db, int id)
        {
            var numberOfReports = Utilities.Instance.GenerateRandomInteger(minNumberOfRecords, maxNumberOfRecords);

            for (int i = 0; i < numberOfReports; i++)
            {
                var text = Utilities.Instance.GenerateRandomString(50, 100);
                var timeOfReport = DateTime.Now;
                var newReport = new Report() { Text = text, TimeOfReport = timeOfReport, EmployeeId = id };

                db.Reports.Add(newReport);
            }

            db.SaveChanges();
        }
    }
}
