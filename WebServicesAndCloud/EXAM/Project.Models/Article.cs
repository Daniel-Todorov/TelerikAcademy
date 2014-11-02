namespace BullsAndCows.Models
{
    using BullsAndCows.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    //using System.Web.Mvc; - to allow html

    public class Article
    {
        public Article()
        {
            this.Comments = new HashSet<Comment>();
            this.Likes = new HashSet<Notification>();
            this.Tags = new HashSet<Guess>();
        }

        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required]
        public string Title { get; set; }

        //[AllowHtml] - to allow html
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Notification> Likes { get; set; }

        public virtual ICollection<Guess> Tags { get; set; }
    }
}
