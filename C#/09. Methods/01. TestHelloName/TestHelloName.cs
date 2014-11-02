using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TestHelloName
{
    [TestMethod]
    public void TestMethod1()
    {
        string testName = null;
        testName = HelloName.SayHello("Daniel");
        Assert.AreEqual("Hello, Daniel!", testName);
    }
}
