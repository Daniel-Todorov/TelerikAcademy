using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TestHelloName
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] testArray = new int[] { 3, 5, 7, 23, 5, 8, 5, 11, 1 };
        int number = 5;
        int testResult = CountNumberAppearance.Counter(testArray, number);
        Assert.AreEqual(3, testResult);
    }
}

