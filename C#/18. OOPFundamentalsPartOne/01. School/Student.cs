using System;

namespace _01.School
{
    public class Student : Person, IComment
    {
        private int studentNumber;

        public string Comment { get; set; }

        public int StudentNumber
        {
            get 
            { 
                return this.studentNumber; 
            }
            set 
            {

            }
        }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }

        public Student(string name, int studentNumber) : base(name)
        {
            this.studentNumber = studentNumber;
        }
    }
}
