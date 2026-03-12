using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            // исходные данные
            int a = 3, b = 5;
            int expected = 15;
            // вычисление
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);
            // сравнение
            Assert.AreEqual(expected, actual);
        }
    }
}