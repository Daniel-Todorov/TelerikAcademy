using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace TestSchool
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void TestStudentNormalName()
        {
            Student student = new Student("Daniel", 11234);
            Assert.AreEqual(student.Name, "Daniel");
        }

        [TestMethod]
        public void TestStudentNormalNumber()
        {
            Student student = new Student("Daniel", 11234);
            Assert.AreEqual(student.UniqueNumber, 11234);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentGreaterThanTenThousandsNumber()
        {
            Student student = new Student("Daniel", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentLowerThanTenThousandsNumber()
        {
            Student student = new Student("Daniel", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentNotUniqueNumber()
        {
            School.School.StudentsInSchool.Add(new Student("Daniel", 10001));
            Student student = new Student("Daniel", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentEmptyStringName()
        {
            Student student = new Student("", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentEmptyName()
        {
            Student student = new Student(string.Empty, 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudentNullName()
        {
            Student student = new Student(null, 10001);
        }
    }
}
