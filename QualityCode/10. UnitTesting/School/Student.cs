using System;

namespace School
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                try
                {
                    if (value.Equals(string.Empty))
                    {
                        throw new ArgumentException("The name of the student can't be empty string.");
                    }
                }
                catch (NullReferenceException e)
                {
                    throw new NullReferenceException("The name of the student can't be null.");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value < 10000)
                {
                    throw new ArgumentOutOfRangeException("The unique number of a student can't be less than 10000.");
                }
                else if (value > 99999)
                {
                    throw new ArgumentOutOfRangeException("The unique number of a student can't be greater than 99999.");
                }
                else if (School.IsDuplicate(value))
                {
                    throw new ArgumentException("A student with such unique number already exists.");
                }

                this.uniqueNumber = value;
            }
        }

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }
    }
}
