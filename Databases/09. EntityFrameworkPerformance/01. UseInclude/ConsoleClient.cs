//Using Entity Framework write a SQL query to select
//all employees from the Telerik Academy databse
//and later print their name, department and town. Try 
//the both variants: with and without .Include(...).
//Compare the number of executed SQL statements
//and the prformance.

using System;
using System.Diagnostics;

namespace _01.UseInclude
{
    public class ConsoleClient
    {
        public static void Main()
        {
            Stopwatch watch = new Stopwatch();
            var db = new TelerikAcademyEntities();

            //Try witout include
            var employees = db.Employees;

            watch.Start();
            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0} {1}, Department: {2}, Town: {3}", 
                    employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }
            watch.Stop();
            var timeElapsedWithoutInclude = watch.Elapsed;

            //Reset clock
            watch.Reset();

            //Try with Include
            var employeesWithIncluded = db.Employees.Include("Department").Include("Address.Town");

            watch.Start();
            foreach (var employee in employeesWithIncluded)
            {
                Console.WriteLine("Name: {0} {1}, Department: {2}, Town: {3}", 
                    employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }
            watch.Stop();
            var timeElapsedWithInclude = watch.Elapsed;

            //Performance results
            Console.WriteLine("Time requred without Include: {0}{1}Time required with Include: {2}", timeElapsedWithoutInclude, Environment.NewLine, timeElapsedWithInclude);
            //Without Include it does so much queries that I couldn't count them int he profiler.
            //With Include it does only two queries to the database.
            //No wonder second option is waaaay faster!
        }
    }
}
