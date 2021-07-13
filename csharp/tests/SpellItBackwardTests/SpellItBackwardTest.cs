using CSharpDiscovery.Quest01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class SpellItBackwardTests
    {
        [TestMethod]
        public void SpellItBackward_HelloWorld_HelloWorldReversed()
        {
            //"helloworld" reçu, on retourne "dlrowolleh"
            Assert.AreEqual("dlrowolleh", SpellItBackward_Exercice.SpellItBackward("helloworld"), "La méthode doit retourner \"dlrowolleh\" pour \"helloworld\" en entrée");
        }
    }
}
