namespace _04.ToDoList
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Todos")]
    public partial class Todo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Body { get; set; }

        public DateTime DateOfLastChange { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
