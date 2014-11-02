using System;

namespace _02.Human
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            string result = null;

            result = string.Format("{0} {1} is at {2} grade", this.FirstName, this.LastName, this.Grade);

            return result;
        } 

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }
    }
}
