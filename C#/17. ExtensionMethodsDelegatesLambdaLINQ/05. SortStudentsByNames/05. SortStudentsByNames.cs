//Using the extension methods OrderBy() and ThenBy() with lambda expressions 
//sort the students by first name and last name in descending order. 
//Rewrite the same with LINQ.

using System;
using System.Linq;

//I am not really sure what is the idea of using OrderBy() and ThenBy() one after the other bu whatever.
class OrderByNames
{
    static void Main()
    {
        Student[] arrayOfStudents = new Student[3];
        arrayOfStudents[0] = new Student("Ivan", "Todorov", 24);
        arrayOfStudents[1] = new Student("Petar", "Petrov", 16);
        arrayOfStudents[2] = new Student("Todor", "Ivanov", 20);

        var result = arrayOfStudents.
            OrderByDescending(student => student.FirstName).
            ThenByDescending(student => student.FamilyName).
            Select(student => string.Format("{0} {1}", student.FirstName, student.FamilyName));
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-----------------------------");

        var wantedStudents = from student in arrayOfStudents
                             orderby student.FirstName descending, student.FamilyName descending
                             select string.Format("{0} {1}", student.FirstName, student.FamilyName);
        foreach (var item in wantedStudents)
        {
            Console.WriteLine(item);
        }
    }
}

public class Student
{
    public string FirstName { get; set; }
    public string FamilyName { get; set; }
    public int Age { get; set; }

    public Student(string firstName, string familyName, int age)
    {
        this.FirstName = firstName;
        this.FamilyName = familyName;
        this.Age = age;
    }
}