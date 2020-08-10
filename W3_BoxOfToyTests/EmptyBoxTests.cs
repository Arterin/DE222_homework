using Microsoft.VisualStudio.TestTools.UnitTesting;
using W3_BoxOfToy;

namespace W3_BoxOfToyTests
{
    [TestClass]
    public class EmptyBoxTests
    {
        [TestMethod]
        public void TestCountIsZero()
        {
            Box theBox = new Box();
            int expectedToyCount = theBox.ToyCount;
            Assert.AreEqual(0, expectedToyCount);
        }
    }
}