namespace BookStoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Author
    {
        public Author()
        {
            Reviews = new HashSet<Review>();
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
