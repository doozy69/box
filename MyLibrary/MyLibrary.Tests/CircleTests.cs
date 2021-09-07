using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Square_()
        {
            double radius = 1;
            double expected = 3.14;

            Circle cir = new Circle(radius);

            Assert.AreEqual(expected, cir.Square());
        }
    }
}
