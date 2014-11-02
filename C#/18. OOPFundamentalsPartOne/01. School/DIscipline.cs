using System;

namespace _01.School
{
    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public string Comment { get; set; }

        public string Name
        {
            get{ return this.name;}
            set { this.name = value; }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }

        public int NumberOfExcercises
        {
            get { return this.numberOfExcercises; }
            set { this.numberOfExcercises = value; }
        }

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExcercises = numberOfExcercises;
        }
    }
}
