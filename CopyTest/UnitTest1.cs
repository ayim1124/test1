using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CopyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsTrue(File.Exists("test1.txt"));
        }
    }
}
