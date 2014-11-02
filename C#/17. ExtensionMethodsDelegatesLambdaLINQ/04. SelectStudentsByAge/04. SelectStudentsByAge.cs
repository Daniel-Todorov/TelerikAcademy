//Write a LINQ query that finds the first name and last name of all students 
//with age between 18 and 24.


using System;
using System.Linq;

//This time I don't use overriding of ToString().
//Instead, the LINQ query returns the needed string.
class SelectStudentByAge
{
    public static void Main()
    {
        Student[] arrayOfStudents = new Student[3];
        arrayOfStudents[0] = new Student("Ivan", "Todorov", 24);
        arrayOfStudents[1] = new Student("Petar", "Petrov", 16);
        arrayOfStudents[2] = new Student("Todor", "Ivanov", 20);

        var wantedStudent = from student in arrayOfStudents
                            where student.Age >= 18 && student.Age <= 24
                            select string.Format("{0} {1}", student.FirstName, student.FamilyName);

        foreach (var item in wantedStudent)
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