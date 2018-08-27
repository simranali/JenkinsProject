using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinCA;
namespace TestJenkinCA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Equals("Hello World", Program.GetMessage());
        }
    }
}
