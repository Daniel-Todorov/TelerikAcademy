  //Define abstract class Human with first name and last name. 
  //Define new class Student which is derived from Human and has new field – grade. 
  //Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
  //Define the proper constructors and properties for this hierarchy. 
  //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

using System;

namespace _02.Human
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
