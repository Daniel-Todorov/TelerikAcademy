namespace CarsModel
{
    using System.Data.Entity;
    using CarsModel.Migrations;

    public partial class CarEntities : DbContext
    {
        public CarEntities()
            : base("name=CarEntities")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarEntities, Configuration>());
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Dealer> Dealers { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Dealers)
                .WithMany(e => e.Cities)
                .Map(m => m.ToTable("DealersCities").MapLeftKey("CityId").MapRightKey("DealerId"));

            modelBuilder.Entity<Dealer>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.Dealer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Cars)
                .WithRequired(e => e.Manufacturer)
                .WillCascadeOnDelete(false);
        }
    }
}
