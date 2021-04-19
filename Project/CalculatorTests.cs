using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public static void Test()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(0.0, x.CalcPremium(17, "male"));
            Assert.AreEqual(6.0, x.CalcPremium(18, "male"));
            Assert.AreEqual(6.0, x.CalcPremium(19, "male"));
            Assert.AreEqual(6.0, x.CalcPremium(34, "male"));
            Assert.AreEqual(6.0, x.CalcPremium(35, "male"));
            Assert.AreEqual(5.0, x.CalcPremium(36, "male"));
            Assert.AreEqual(5.0, x.CalcPremium(37, "male"));
            Assert.AreEqual(5.0, x.CalcPremium(49, "male"));
            Assert.AreEqual(2.5, x.CalcPremium(50, "male"));
            Assert.AreEqual(2.5, x.CalcPremium(51, "male"));

            Assert.AreEqual(0.0, x.CalcPremium(17, "female"));
            Assert.AreEqual(5.0, x.CalcPremium(18, "female"));
            Assert.AreEqual(5.0, x.CalcPremium(19, "female"));
            Assert.AreEqual(5.0, x.CalcPremium(29, "female"));
            Assert.AreEqual(5.0, x.CalcPremium(30, "female"));
            Assert.AreEqual(3.5, x.CalcPremium(31, "female"));
            Assert.AreEqual(3.5, x.CalcPremium(49, "female"));
            Assert.AreEqual(1.75, x.CalcPremium(50, "female"));
            Assert.AreEqual(1.75, x.CalcPremium(51, "female"));

            Assert.AreEqual(0.0, x.CalcPremium(22, "evil mario"));
        }
    }
}

