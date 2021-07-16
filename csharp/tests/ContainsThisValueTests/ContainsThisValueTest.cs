using CSharpDiscovery.Quest05;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class FindThisValueTests
    {
        [TestMethod]
        public void FindThisValue_ValueHere_True()
        {
            Assert.IsTrue(FindThisValue_Exercice.FindThisValue(new int[] { 1, 2, 3, 4, 5 }, 5));
        }

        [TestMethod]
        public void FindThisValue_ValueNotHere_False()
        {
            Assert.IsFalse(FindThisValue_Exercice.FindThisValue(new int[] { 1, 2, 3, 4, 5 }, 15));
        }

        [TestMethod]
        public void FindThisValue_tabEmpty_False()
        {
            Assert.IsFalse(FindThisValue_Exercice.FindThisValue(new int[0], 15));
        }

        [TestMethod]
        public void FindThisValue_tabNull_False()
        {
            Assert.IsFalse(FindThisValue_Exercice.FindThisValue(null, 15));
        }
    }
}
