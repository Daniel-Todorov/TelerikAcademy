namespace BullsAndCows.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        public Game()
        {
            this.Guesses = new HashSet<Guess>();
            this.Notifications = new HashSet<Notification>();
        }

        [Key]
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string RedPlayerId { get; set; }
        public virtual ApplicationUser RedPlayer { get; set; }

        [MinLength(4)]
        [MaxLength(4)]
        public string RedPlayerNumber { get; set; }

        public string BluePlayerId { get; set; }
        public virtual ApplicationUser BluePlayer { get; set; }

        [MinLength(4)]
        [MaxLength(4)]
        public string BluePlayerNumber { get; set; }

        [Required]
        public GameState GameState { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<Guess> Guesses { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
