using System;
using System.Collections.Generic;

namespace School
{
    public class Course
    {
        private List<Student> studentsInCourse;

        public List<Student> StudentsInCourse
        {
            get
            {
                return this.studentsInCourse;
            }
            set
            {
                try
                {
                    if (value.Count > 30)
                    {
                        throw new ArgumentException("The course cannot have more than 30 students.");
                    }
                    else if (value.Count < 0)
                    {
                        throw new ArgumentException("The number of students in the course cannot be negative");
                    }
                }
                catch (NullReferenceException e)
                {
                    throw new ArgumentNullException("The number of students in the course cannot be null");
                }

                this.studentsInCourse = value;
            }
        }

        public Course(List<Student> studentsInCourse)
        {
            this.StudentsInCourse = studentsInCourse;
        }
    }
}
