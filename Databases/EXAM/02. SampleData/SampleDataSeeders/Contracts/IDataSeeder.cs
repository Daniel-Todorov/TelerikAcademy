namespace SampleDataSeeders.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CompanyEntities;

    public interface IDataSeeder
    {
        void SeedData(CompanyEntities db);
    }
}
