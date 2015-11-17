using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tuple<double, double> a = new Tuple<double, double>(1.0, 1.0);
            Tuple<double, double> b = new Tuple<double, double>(5.0, 5.0);
            Tuple<double, double> c = new Tuple<double, double>(0.0, 0.0);
            Tuple<double, double> d = new Tuple<double, double>(5.0, 0.0);
            Assert.IsFalse(TwoLines.IsIntersect(a, b, c, d));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Tuple<double, double> a = new Tuple<double, double>(2.0, 1.0);
            Tuple<double, double> b = new Tuple<double, double>(2.0, 1.0);
            Tuple<double, double> c = new Tuple<double, double>(2.0, 1.0);
            Tuple<double, double> d = new Tuple<double, double>(2.0, 1.0);
            Assert.IsTrue(TwoLines.IsIntersect(a, b, c, d));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Tuple<double, double> a = new Tuple<double, double>(0.5, 2.0);
            Tuple<double, double> b = new Tuple<double, double>(2.5, 1.25);
            Tuple<double, double> c = new Tuple<double, double>(0.0, 1.0);
            Tuple<double, double> d = new Tuple<double, double>(2.0, 2.0);
            Assert.IsTrue(TwoLines.IsIntersect(a, b, c, d));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Tuple<double, double> a = new Tuple<double, double>(500, 200);
            Tuple<double, double> b = new Tuple<double, double>(600, 100);
            Tuple<double, double> c = new Tuple<double, double>(-100, 300);
            Tuple<double, double> d = new Tuple<double, double>(500, 1);
            Assert.IsFalse(TwoLines.IsIntersect(a, b, c, d));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Tuple<double, double> a = new Tuple<double, double>(5, 200);
            Tuple<double, double> b = new Tuple<double, double>(60, 100);
            Tuple<double, double> c = new Tuple<double, double>(-10, -300);
            Tuple<double, double> d = new Tuple<double, double>(-50, -1);
            Assert.IsFalse(TwoLines.IsIntersect(a, b, c, d));
        }
    }
}
