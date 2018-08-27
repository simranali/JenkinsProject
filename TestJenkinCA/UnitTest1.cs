using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinCA;
namespace TestJenkinCA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMessageTest()
        {
            Assert.AreEqual("Hello World", Program.GetMessage());
            
            //Assert.AreEqual("Hello World","Hello World");
        }
        [TestMethod]
        public void GetSecondMessageTest()
        {
            Assert.AreEqual("Hello World", Program.GetSecondMessage());

            //Assert.AreEqual("Hello World","Hello World");
        }

        //public UnitTest1()
        //{
        //    this.TestMethod1();
        //}
    }
}
