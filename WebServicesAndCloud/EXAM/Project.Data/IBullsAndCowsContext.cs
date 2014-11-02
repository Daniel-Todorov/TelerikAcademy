namespace BullsAndCows.Data
{
    using System.Data.Entity;

    using BullsAndCows.Models;

    public interface IBullsAndCowsContext
    {
        //IDbSet<ApplicationUser> Users { get; set; }

        IDbSet<Notification> Notifications { get; set; }

        IDbSet<Guess> Guesses { get; set; }

        IDbSet<Game> Game { get; set; }

        IDbSet<T> Set<T>() where T : class;

        //DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();
    }
}
