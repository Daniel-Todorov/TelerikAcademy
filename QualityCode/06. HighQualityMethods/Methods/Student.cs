using System;

namespace Methods
{
    /// <summary>
    /// Defines a student
    /// </summary>
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }
        private string DateOfBirth
        {
            get
            {
                return this.DateOfBirth;
            }
            set
            {
                this.DateOfBirth = this.OtherInfo.Substring(this.OtherInfo.Length - 10);
            }
        }

        public bool IsOlderThan(Student otherStudent)
        {
            
            DateTime firstDate = DateTime.Parse(this.DateOfBirth);
            DateTime secondDate = DateTime.Parse(otherStudent.DateOfBirth);
            return firstDate > secondDate;
        }
    }
}
