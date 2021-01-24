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
        [TestMethod]
        public void Task3()
        {
            try
            {
                Task3 t = new Task3();
                t.Stor = 5;
                t.X1 = 0;
                t.Y1 = 0;
                t.X2 = 5;
                t.Y2 = 2.5;
                t.Y3 = 2.5;
                t.X3 = 5;
                t.Y4 = 5;
                t.X4 = 0;
                t.kvadrat = new int[1000, 1000];
                t.Vichislenia(t.Stor / 1000);
                Assert.AreEqual(1, 1);
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
