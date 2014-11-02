namespace BullsAndCows.Web.Models
{
    using System;
    using System.Collections.Generic;

    public class GameDetails
    {
        public int Id;
        public string Name;
        public DateTime DateCreated;
        public string Red;
        public string Blue;
        public string YourNumber;
        public List<GuessDetails> YourGuesses;
        public List<GuessDetails> OpponentGuesses;
        public string YourColor;
        public string GameState;
    }
}