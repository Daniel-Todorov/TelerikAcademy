namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        [Key]
        public int HomeworkID { get; set; }

        [StringLength(5000)]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        public int CourseID { get; set; }
        public virtual Course Course { get; set; }

    }
}
