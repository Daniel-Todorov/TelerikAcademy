namespace _06.StoringNumberOfVisitsInMSSQLServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_06.StoringNumberOfVisitsInMSSQLServer.CounterEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(_06.StoringNumberOfVisitsInMSSQLServer.CounterEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            context.Visits.AddOrUpdate(new Visit() { NumberOfVisits = 0 });
            context.SaveChanges();
        }
    }
}
