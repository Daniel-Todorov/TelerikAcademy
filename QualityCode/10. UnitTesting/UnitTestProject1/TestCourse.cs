using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void TestCourseWithZeroStudents()
        {
            List<Student> students = new List<Student>();

            Course newCourse = new Course(students);
            Assert.AreEqual(0, newCourse.StudentsInCourse.Count);
        }

        [TestMethod]
        public void TestCourseWithThirtyStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Daniel", 10001));
            students.Add(new Student("Daniel", 10002));
            students.Add(new Student("Daniel", 10003));
            students.Add(new Student("Daniel", 10004));
            students.Add(new Student("Daniel", 10005));
            students.Add(new Student("Daniel", 10006));
            students.Add(new Student("Daniel", 10007));
            students.Add(new Student("Daniel", 10008));
            students.Add(new Student("Daniel", 10009));
            students.Add(new Student("Daniel", 10010));
            students.Add(new Student("Daniel", 10011));
            students.Add(new Student("Daniel", 10012));
            students.Add(new Student("Daniel", 10013));
            students.Add(new Student("Daniel", 10014));
            students.Add(new Student("Daniel", 10015));
            students.Add(new Student("Daniel", 10016));
            students.Add(new Student("Daniel", 10017));
            students.Add(new Student("Daniel", 10018));
            students.Add(new Student("Daniel", 10019));
            students.Add(new Student("Daniel", 10020));
            students.Add(new Student("Daniel", 10021));
            students.Add(new Student("Daniel", 10022));
            students.Add(new Student("Daniel", 10023));
            students.Add(new Student("Daniel", 10024));
            students.Add(new Student("Daniel", 10025));
            students.Add(new Student("Daniel", 10026));
            students.Add(new Student("Daniel", 10027));
            students.Add(new Student("Daniel", 10028));
            students.Add(new Student("Daniel", 10029));
            students.Add(new Student("Daniel", 10030));

            Course newCourse = new Course(students);
            Assert.AreEqual(30, newCourse.StudentsInCourse.Count);
        }

        [TestMethod]
        public void TestCourseWithTenStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Daniel", 10001));
            students.Add(new Student("Daniel", 10002));
            students.Add(new Student("Daniel", 10003));
            students.Add(new Student("Daniel", 10004));
            students.Add(new Student("Daniel", 10005));
            students.Add(new Student("Daniel", 10006));
            students.Add(new Student("Daniel", 10007));
            students.Add(new Student("Daniel", 10008));
            students.Add(new Student("Daniel", 10009));
            students.Add(new Student("Daniel", 10010));

            Course newCourse = new Course(students);
            Assert.AreEqual(10, newCourse.StudentsInCourse.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseNullStudents()
        {
            Course newCourse = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseWithMoreThanThirthyStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Daniel", 10001));
            students.Add(new Student("Daniel", 10002));
            students.Add(new Student("Daniel", 10003));
            students.Add(new Student("Daniel", 10004));
            students.Add(new Student("Daniel", 10005));
            students.Add(new Student("Daniel", 10006));
            students.Add(new Student("Daniel", 10007));
            students.Add(new Student("Daniel", 10008));
            students.Add(new Student("Daniel", 10009));
            students.Add(new Student("Daniel", 10010));
            students.Add(new Student("Daniel", 10011));
            students.Add(new Student("Daniel", 10012));
            students.Add(new Student("Daniel", 10013));
            students.Add(new Student("Daniel", 10014));
            students.Add(new Student("Daniel", 10015));
            students.Add(new Student("Daniel", 10016));
            students.Add(new Student("Daniel", 10017));
            students.Add(new Student("Daniel", 10018));
            students.Add(new Student("Daniel", 10019));
            students.Add(new Student("Daniel", 10020));
            students.Add(new Student("Daniel", 10021));
            students.Add(new Student("Daniel", 10022));
            students.Add(new Student("Daniel", 10023));
            students.Add(new Student("Daniel", 10024));
            students.Add(new Student("Daniel", 10025));
            students.Add(new Student("Daniel", 10026));
            students.Add(new Student("Daniel", 10027));
            students.Add(new Student("Daniel", 10028));
            students.Add(new Student("Daniel", 10029));
            students.Add(new Student("Daniel", 10030));
            students.Add(new Student("Daniel", 10031));

            Course newCourse = new Course(students);
        }
    }
}
