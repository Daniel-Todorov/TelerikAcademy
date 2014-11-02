namespace BookStoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public Book()
        {
            Reviews = new HashSet<Review>();
            Authors = new HashSet<Author>();
        }

        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [MinLength(13)]
        [MaxLength(13)]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
