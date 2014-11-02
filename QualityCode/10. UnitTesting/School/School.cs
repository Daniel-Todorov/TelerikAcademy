using System;
using System.Collections.Generic;

namespace School
{
    public static class School
    {
        private static List<Student> studentsInSchool = new List<Student>();

        public static List<Student> StudentsInSchool
        {
            get
            {
                return School.studentsInSchool;
            }
            set
            {
                try
                {
                    if (value.Count == 0)
                    {
                        throw new ArgumentException("The number of students in the school can't be zero.");
                    }
                }
                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("The number of students in the school can't be null.");
                }

                School.studentsInSchool = value;
            }
        }

        public static bool IsDuplicate(int newStudentNumber)
        {
            foreach (var student in studentsInSchool)
            {
                if (student.UniqueNumber == newStudentNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
