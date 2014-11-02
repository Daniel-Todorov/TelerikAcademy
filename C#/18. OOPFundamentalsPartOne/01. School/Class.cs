using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Class : IComment
    {
        private string identifier;
        private List<Student> students;
        private List<Teacher> teachers;

        public string Comment { get; set; }

        public string Identifier
        {
            get { return this.Identifier; }
            set { this.identifier = value; }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

        public Class(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.identifier = identifier;
            this.students = students;
            this.teachers = teachers;
        }
    }
}
