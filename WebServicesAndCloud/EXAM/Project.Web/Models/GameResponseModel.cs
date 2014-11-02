namespace BullsAndCows.Web.Models
{
    using System;

    using BullsAndCows.Models;

    public class GameResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Blue { get; set; }

        public string Red { get; set; }

        public string GameState { get; set; }

        public DateTime DateCreated { get; set; }
    }
}