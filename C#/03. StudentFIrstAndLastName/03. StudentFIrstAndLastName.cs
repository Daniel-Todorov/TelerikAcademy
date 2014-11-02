//Write a method that from a given array of students finds all students 
//whose first name is before its last name alphabetically. 
//Use LINQ query operators.


using System;
using System.Linq;

//I have written a class student and overriden ToString().
class StudentFIrstAndLastName
{
    public static void Main()
    {
        Student[] arrayOfStudents = new Student[3];
        arrayOfStudents[0] = new Student("Ivan", "Todorov");
        arrayOfStudents[1] = new Student("Petar", "Petrov");
        arrayOfStudents[2] = new Student("Todor", "Ivanov");

        var wantedStudents = from names in arrayOfStudents
                             where names.FirstName.CompareTo(names.FamilyName) < 0
                             select names;

        foreach (var item in wantedStudents)
        {
            Console.WriteLine("{0} ", item.ToString());
        }
    }
}

public class Student
{
    public string FirstName { get; set; }
    public string FamilyName { get; set; }

    public Student(string firstName, string familyName)
    {
        this.FirstName = firstName;
        this.FamilyName = familyName;
    }

    public override string ToString()
    {
        string result = string.Format("{0} {1}", this.FirstName, this.FamilyName);

        return result;
    }
}