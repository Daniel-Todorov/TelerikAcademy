//01. Create a code first database following the given example. Allow migration.

//NOTE!!! Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>()); is in the StudentSystemContext class

namespace StudentSystem
{
    using System;
    using System.Linq;

    using StudentSystem.Context;

    //02. Write a console application that uses the data
    class ConsoleClient
    {
        static void Main()
        {
            var db = new StudentSystemContext();

            //03. Seed the database with random values -> the Seed method of Configuration class
            
            var thirdStudent = db.Students.Where(student => student.StudentID == 3).First();
            var homeworksOfThirdStudent = db.Homeworks.Where(homework => homework.StudentID == thirdStudent.StudentID).ToList();

            Console.WriteLine(thirdStudent.Name + "has written his homework for: ");
            foreach (var homework in homeworksOfThirdStudent)
            {
                Console.WriteLine("\"" + homework.Course.Name + "\"");
            }
        }
    }
}
