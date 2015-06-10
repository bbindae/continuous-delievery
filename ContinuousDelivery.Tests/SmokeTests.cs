using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ContinuousDelivery.Tests
{
    [TestFixture]
    public class SmokeTests
    {
        [Test]
        public void Can_Add_Two_Numbers()
        {
            var num1 = 1;
            var num2 = 2;

            var num3 = num1 + num2;

            Assert.AreEqual(3, num3);
        }
    }
}
