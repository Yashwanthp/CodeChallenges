using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyATMMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATMMachine.Tests
{
    [TestClass()]
    public class MyCashTests
    {
        [TestMethod()]
        public void DenominationsDescriptionTest()
        {
            ICurrency c = new MyCash(1000);
            c.CalculateDenominations();
            var x = c.DenominationsDescription();
            Assert.AreEqual(x, "1000 X 1\n500 X 0\n100 X 0");
            
        }

        [TestMethod()]
        public void DenominationsDescriptionTestWrong()
        {
            ICurrency c = new MyCash(1000);
            c.CalculateDenominations();
            var x = c.DenominationsDescription();
            Assert.AreNotEqual(x, "1000 X 0\n500 X 0\n100 X 10");

        }
    }
}