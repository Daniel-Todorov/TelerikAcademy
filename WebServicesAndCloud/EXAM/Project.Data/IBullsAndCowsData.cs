namespace BullsAndCows.Data
{
    using BullsAndCows.Data.Repositories;
    using BullsAndCows.Models;

    public interface IBullsAndCowsData
    {
        IGenericRepository<ApplicationUser> Users { get; }

        IGenericRepository<Guess> Guesses { get; }

        IGenericRepository<Notification> Notifications { get; }

        IGenericRepository<Game> Games { get; }

        int SaveChanges();
    }
}
