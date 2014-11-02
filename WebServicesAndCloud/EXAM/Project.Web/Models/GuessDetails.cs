namespace BullsAndCows.Web.Models
{
    using System;

    public class GuessDetails
    {
        public int Id;
        public string UserId;
        public string Username;
        public int GameId;
        public string Number;
        public DateTime DateMade;
        public int? CowsCount;
        public int? BullsCount;
    }
}