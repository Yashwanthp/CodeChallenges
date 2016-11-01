using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyATMMachine.Tests
{
    [TestClass()]
    public class MyCashDispenserTests
    {
        [TestMethod()]
        public void ValidAmounttoDispenceTest()
        {
            var cash = 1000;
            MyCashDispenser cd = new MyCashDispenser();
            var x = cd.ValidAmounttoDispence(cash);
            Assert.AreEqual(x,true);
        }

        [TestMethod()]
        public void ValidWrongAmounttoDispenceTest()
        {
            var cash = 1050;
            MyCashDispenser cd = new MyCashDispenser();
            var x = cd.ValidAmounttoDispence(cash);
            Assert.AreEqual(x, false);
        }
    }
}