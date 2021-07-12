using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDiscovery.Quest01;

namespace CSharpDiscoveryTests.Quest01Tests
{
    [TestClass]
    public class _03_IsOddTests
    {
        [TestMethod]
        public void IsOdd_OddInteger_True()
        {
            Assert.IsTrue(_03_IsOdd.IsOdd(34));
        }

        [TestMethod]
        public void IsOdd_EvenInteger_False()
        {
            Assert.IsFalse(_03_IsOdd.IsOdd(33));
        }
        [TestMethod]
        public void IsOdd_EvenInteger_Zero()
        {
            Assert.IsTrue(_03_IsOdd.IsOdd(0));
        }
        [TestMethod]
        public void IsOdd_EvenInteger_One()
        {
            Assert.IsFalse(_03_IsOdd.IsOdd(1));
        }
    }
}
