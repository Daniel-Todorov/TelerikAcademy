namespace BullsAndCows.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    using BullsAndCows.Models;
    using BullsAndCows.Data.Migrations;

    public class BullsAndCowsContext : IdentityDbContext<ApplicationUser>, IBullsAndCowsContext
    {
        public BullsAndCowsContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BullsAndCowsContext, Configuration>());
        }

        public static BullsAndCowsContext Create()
        {
            return new BullsAndCowsContext();
        }

        //public IDbSet<ApplicationUser> Users { get; set; }

        public IDbSet<Guess> Guesses { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

        public IDbSet<Game> Game { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
