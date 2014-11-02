namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CompanyEntities;
    using SampleDataSeeders;
    using SampleDataSeeders.Contracts;

    using System.Threading.Tasks;
    public class ConsoleClient
    {
        static void Main()
        {
            //NOTE!!! I am using SQL server. 
            //If you are using SQLEXPRESS, please change the conection string.
            var db = new CompanyEntities();
            db.Configuration.AutoDetectChangesEnabled = false;

            List<IDataSeeder> seeders = new List<IDataSeeder>();
            seeders.Add(new DepartmentSeeder(100));
            seeders.Add(new EmployeeSeeder(5000));
            seeders.Add(new ManagerSeeder());
            seeders.Add(new ReportSeeder(25, 75)); //between 50 per employee
            seeders.Add(new ProjectSeeder(1000));

            foreach (var seeder in seeders)
            {
                seeder.SeedData(db);
            }

            db.SaveChanges();
        }
    }
}
