using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CopyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DeploymentItem("test1.txt")]
        [DeploymentItem("test2.txt")]
        public void ConstructorTest()
        {
            Assert.IsTrue(File.Exists("test1.txt"));
        }

        [TestMethod]
        public void ConstructorTest1()
        {
            Assert.IsTrue(File.Exists("test2.txt"));
        }
    }
}
