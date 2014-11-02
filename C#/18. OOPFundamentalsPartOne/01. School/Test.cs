using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Test
    {
        public static void Main()
        {
            Discipline firstDiscipline = new Discipline("history", 2, 5);
            Discipline secondDiscipline = new Discipline("math", 8, 4);

            Student firstStudent = new Student("Daniel", 1);
            Student secondStudent = new Student("Ivan", 2);

            Teacher firstTeacher = new Teacher("Petrov", new List<Discipline> { firstDiscipline, secondDiscipline });

            Class firstClass = new Class("1A", new List<Student> { firstStudent, secondStudent }, new List<Teacher> { firstTeacher });

            School firstSchool = new School(new List<Class> { firstClass });

            Console.WriteLine("The name of the first discipline of the first teacher in 1A class is: {0}",firstSchool.Classes[0].Teachers[0].SetOfDisciplines[0].Name);
            
            firstSchool.Classes[0].Comment = "The best students ever!";
            Console.WriteLine(firstSchool.Classes[0].Comment);
        }
    }
}
