namespace BullsAndCows.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Message { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public NotificationType Type { get; set; }

        public NotificationState State { get; set; }

        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        public string PlayerId { get; set; }
        public virtual ApplicationUser Player { get; set; }
    }
}
