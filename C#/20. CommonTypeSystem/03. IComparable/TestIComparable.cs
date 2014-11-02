//The problem is implemented in Student.cs in the first problem.
//This is a class that tests the result.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudent
{
    class TestIComparable
    {
        static void Main()
        {
            Student testSubject = new Student("Ivan", "Zhelyazkov", "Todorov", 8911068523, "Sofia", 0886889900, "ivan@gmail.com", 3, 
                Specialty.Law, University.SofiaUnivercity, Faculty.Legal);

            Student cloneSubject = testSubject.Clone();

            Console.WriteLine(testSubject.CompareTo(cloneSubject));

            testSubject.FirstName = "Daniel";

            Console.WriteLine(testSubject.CompareTo(cloneSubject));
            Console.WriteLine(cloneSubject.CompareTo(testSubject));

            testSubject.FirstName = "Ivan";

            Console.WriteLine(testSubject.CompareTo(cloneSubject));
        }
    }
}
