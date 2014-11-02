namespace StudentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    using StudentSystem.Context;
    using StudentSystem.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Context.StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var student1 = new Student() { StudentID = 1, Name = "Daniel", Number = "1234567890" };
            var student2 = new Student() { StudentID = 2, Name = "Petar", Number = "8652430943" };
            var student3 = new Student() { StudentID = 3, Name = "Maria", Number = "abvgde4567" };

            var course1 = new Course() { CourseID = 1, Name = "How to make spaggetti", Description = "The course will teach you how to cook spaggetti", Materials = "A cook book for preparing spaggetti; A safety guide" };
            var course2 = new Course() { CourseID = 2, Name = "Spaggetti souce making", Description = "The course will teach you how to make awesoem spaggetti souce", Materials = "Top 100 spaggetti souces cookbook; A safety manual" };

            student2.Courses.Add(course1);
            student3.Courses.Add(course2);
            student2.Courses.Add(course2);

            course1.Students.Add(student1);

            context.Students.AddOrUpdate(student1);
            context.Students.AddOrUpdate(student2);
            context.Students.AddOrUpdate(student3);

            context.Courses.AddOrUpdate(course1);
            context.Courses.AddOrUpdate(course2);

            var homework1 = new Homework() { Content = "2 * PI * r = radius if a circle spaggetti", CourseID = 1, StudentID = 2, TimeSent = DateTime.Now };
            var homework2 = new Homework() { Content = "3 * PI * r = super pizzaa", CourseID = 1, StudentID = 3, TimeSent = DateTime.Now };
            var homework3 = new Homework() { Content = "This is my magical white souce for spaggetti", CourseID = 2, StudentID = 3, TimeSent = DateTime.Now };

            homework1.Course = course1;
            homework1.Student = student2;
            homework2.Course = course1;
            homework2.Student=student3;
            homework3.Course = course2;
            homework3.Student = student3;

            context.Homeworks.AddOrUpdate(homework1);
            context.Homeworks.AddOrUpdate(homework2);
            context.Homeworks.AddOrUpdate(homework3);
        }
    }
}
