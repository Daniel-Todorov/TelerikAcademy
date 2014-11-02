namespace _06.StoringNumberOfVisitsInMSSQLServer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using _06.StoringNumberOfVisitsInMSSQLServer.Migrations;

    public partial class CounterEntities : DbContext
    {
        public CounterEntities()
            : base("name=CounterEntities")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CounterEntities, Configuration>());
        }

        public virtual DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
