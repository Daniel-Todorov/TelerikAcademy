//The solution is implemented in the Student.cs in the first problem.
//This is a test program to make sure the copy is deep.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudent
{
    class TestICloneable
    {
        static void Main()
        {
            Student testSubject = new Student("Ivan", "Zhelyazkov", "Todorov", 8911068523, "Sofia", 0886889900, "ivan@gmail.com", 3, 
                Specialty.Law, University.SofiaUnivercity, Faculty.Legal);

            Student cloneSubject = testSubject.Clone();

            Console.WriteLine(cloneSubject);
            cloneSubject.FirstName = "Daniel";
            Console.WriteLine(cloneSubject);
            Console.WriteLine(testSubject);
        }
    }
}
