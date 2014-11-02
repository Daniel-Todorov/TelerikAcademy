namespace BullsAndCows.Models
{
    using BullsAndCows.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Comment
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }

        public DateTime DateCreated { get; set; }

        public string Content { get; set; }
    }
}
