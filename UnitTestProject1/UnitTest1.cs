using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1()
        {
            try
            {
                Pole p = new Pole();
                Assert.AreEqual(1, 1);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void Task2()
        {
            try
            {
                Koord_yglbl k = new Koord_yglbl();
                Assert.AreEqual(1, 1);
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
