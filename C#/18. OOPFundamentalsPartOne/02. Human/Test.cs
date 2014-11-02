using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Human
{
    class Test
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Alex", "Petrov", 1));
            students.Add(new Student("Ali", "Macbil", 1));
            students.Add(new Student("Boris", "Hristov", 2));
            students.Add(new Student("Vasil", "Hristov", 3));
            students.Add(new Student("Miroslav", "Vasilev", 6));
            students.Add(new Student("Petar", "Vasilev", 8));
            students.Add(new Student("Daniel", "Todorov", 12));
            students.Add(new Student("Ivan", "Todorov", 3));
            students.Add(new Student("Stoil", "manchev", 7));
            students.Add(new Student("Velin", "Vodenicharov", 1));

            var linq = from student in students 
                       orderby student.Grade 
                       select student;

            foreach (var student in linq)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Alex", "Petrov", 100, 40));
            workers.Add(new Worker("Ali", "Macbil", 123, 30));
            workers.Add(new Worker("Boris", "Hristov", 210, 10));
            workers.Add(new Worker("Vasil", "Hristov", 315, 50));
            workers.Add(new Worker("Miroslav", "Vasilev", 602, 70));
            workers.Add(new Worker("Petar", "Vasilev", 805, 80));
            workers.Add(new Worker("Daniel", "Todorov", 120, 20));
            workers.Add(new Worker("Ivan", "Todorov", 300, 45));
            workers.Add(new Worker("Stoil", "manchev", 78, 4));
            workers.Add(new Worker("Velin", "Vodenicharov", 1000, 1));

            var newWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

            foreach (var worker in newWorkers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
