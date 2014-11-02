namespace BullsAndCows.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Guess
    {
        [Key]
        public int Id { get; set; }

        public string PlayerId { get; set; }
        public virtual ApplicationUser Player { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        public string Number { get; set; }

        public DateTime DateMade { get; set; }

        public int? CowsCount { get; set; }

        public int? BullsCount { get; set; }
    }
}
