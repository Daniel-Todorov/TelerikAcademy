using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudent
{
    class Test
    {
        static void Main()
        {
            Student testSubject = new Student("Ivan", "Zhelyazkov", "Todorov", 8911068523, "Sofia", 0886889900, "ivan@gmail.com", 3, 
                Specialty.Law, University.SofiaUnivercity, Faculty.Legal);

            Student newTestSubject = new Student("Ivan", "Zhelyazkov", "Todorov", 8911068523, "Sofia", 0886889900, "ivan@gmail.com", 3,
                Specialty.Law, University.SofiaUnivercity, Faculty.Legal); ;

            Console.WriteLine(testSubject.ToString());
            Console.WriteLine(newTestSubject);

            if (testSubject.Equals(newTestSubject))
            {
                Console.WriteLine("TestSubject EQUALS NewTestSubject");
            }
            else
            {
                Console.WriteLine("TestSubject DOES NOT equal NewTestSubject");
            }

            if (testSubject == newTestSubject)
            {
                Console.WriteLine("TestSubject == NewTestSubject");
            }
            else if (testSubject != newTestSubject)
            {
                Console.WriteLine("TestSubject != NewTestSubject");
            }

            Console.WriteLine("The hash code is: {0}", testSubject.GetHashCode());
        }
    }
}
