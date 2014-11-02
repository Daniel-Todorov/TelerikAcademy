using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        public void TestSchoolWithOneStudent()
        {
            List<Student> studentsInSchool = new List<Student>();
            studentsInSchool.Add(new Student("Daniel", 11111));
            School.School.StudentsInSchool = studentsInSchool;

            Assert.AreEqual(School.School.StudentsInSchool.Count, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolWithZeroStudent()
        {
            School.School.StudentsInSchool = new List<Student>();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestSchoolWithNullStudent()
        {
            School.School.StudentsInSchool = null;
        }
    }
}
