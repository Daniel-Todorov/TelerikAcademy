namespace NewsSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Like
    {
        public Like()
        {
            Articles = new HashSet<Article>();
        }

        public int Id { get; set; }

        public int Value { get; set; }

        public int AuthorId { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}