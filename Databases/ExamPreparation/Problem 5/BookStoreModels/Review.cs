namespace BookStoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Review
    {
        public int ReviewId { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int? AuthorId { get; set; }

        public int BookId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }
    }
}
