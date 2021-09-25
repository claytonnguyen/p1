using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace P1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsExpired_False()
        {
            Entree testObj = new Entree();
            Assert.AreEqual(testObj.IsExpired(), false);
        }
    }
}
