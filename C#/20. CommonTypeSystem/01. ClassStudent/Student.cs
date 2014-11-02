//1. Define a class , which contains data about a student
//– first, middle and last name, SSN, permanent address, mobile phone, e-mail, course, specialty, university, faculty. 
//Use an enumeration for the specialties, universities and faculties. 
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//2. Add implementations of the ICloneable interface. 
//The method should deeply copy all object's fields into a new object of type Student.

//3. Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
//and by social security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ClassStudent
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; } //This could also be a string, if you want to be sure any kind of SSNs can be stored.
        public string PermanentAdress { get; set; }
        public ulong MobilePhone { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; } //I consider that the student can be first, second, third ... course
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        //Problem 3
        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName.CompareTo(otherStudent.FirstName) > 0)
            {
                return 1;
            }
            else if (this.FirstName.CompareTo(otherStudent.FirstName) < 0)
            {
                return -1;
            }

            if (this.MiddleName.CompareTo(otherStudent.MiddleName) > 0)
            {
                return 1;
            }
            else if (this.MiddleName.CompareTo(otherStudent.MiddleName) < 0)
            {
                return -1;
            }

            if (this.LastName.CompareTo(otherStudent.LastName) > 0)
            {
                return 1;
            }
            else if (this.LastName.CompareTo(otherStudent.LastName) < 0)
            {
                return -1;
            }

            if (this.SSN < otherStudent.SSN)
            {
                return 1;
            }
            else if (this.SSN > otherStudent.SSN)
            {
                return -1;
            }

            return 0;
        }
         
        //Problem 2
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student result = new Student();
            result.FirstName = this.FirstName;
            result.MiddleName = this.MiddleName;
            result.LastName = this.LastName;
            result.SSN = this.SSN;
            result.PermanentAdress = this.PermanentAdress;
            result.MobilePhone = this.MobilePhone;
            result.Email = this.Email;
            result.Course = this.Course;
            result.Specialty = this.Specialty;
            result.University = this.University;
            this.Faculty = this.Faculty;

            return result;
        }


        //Problem 1
        public override string ToString()
        {
            string result = string.Format("First name: {0}, Middle name: {1}, Last name: {2}, SSN: {3}, University: {4}", 
                this.FirstName, this.MiddleName, this.LastName, this.SSN, this.University);

            return result;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            bool result = firstStudent.Equals(secondStudent);

            return result;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            bool result = !firstStudent.Equals(secondStudent);

            return result;
        }

        public override bool Equals(object student)
        {
            Student newStudent = student as Student;

            if (Object.Equals(this.FirstName, newStudent.FirstName) && Object.Equals(this.MiddleName, newStudent.MiddleName) && 
                Object.Equals(this.LastName, newStudent.LastName) && this.SSN == newStudent.SSN)
            {
                return true;
            }
        
            return false;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode();
        }

        public Student(string firstName, string middleName, string lastName, ulong ssn, string permanentAdress, ulong mobilePhone,
            string email, byte course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAdress = permanentAdress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public Student()
        {

        }
    }
}
