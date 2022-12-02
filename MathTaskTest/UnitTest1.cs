using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskMorozov;

namespace MathTaskTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RectangleArea_3and5_15retyrned()
        {
            int s = 4;
            int h = 8;
            int expected = 32;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(s, h);

            Assert.AreEqual(expected, actual);
        }
    }
}
