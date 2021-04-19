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
        }

        [Test]
        public static void Test2()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(6.0, x.CalcPremium(18, "male"));
        }

        [Test]
        public static void Test3()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(6.0, x.CalcPremium(19, "male"));
        }

        [Test]
        public static void Test4()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(6.0, x.CalcPremium(34, "male"));
        }

        [Test]
        public static void Test5()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(6.0, x.CalcPremium(35, "male"));
        }

        [Test]
        public static void Test6()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(5.0, x.CalcPremium(36, "male"));
        }

        [Test]
        public static void Test7()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(5.0, x.CalcPremium(37, "male"));
        }

        [Test]
        public static void Test8()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(5.0, x.CalcPremium(49, "male"));
        }

        [Test]
        public static void Test9()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(2.5, x.CalcPremium(50, "male"));
        }

        [Test]
        public static void Test10()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(2.5, x.CalcPremium(50, "male"));
        }

        [Test]
        public static void Test11()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(2.5, x.CalcPremium(51, "male"));
        }

        [Test]
        public static void Test12()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(0.0, x.CalcPremium(17, "female"));
        }

        [Test]
        public static void Test13()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(5.0, x.CalcPremium(18, "female"));
        }

        [Test]
        public static void Test14()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(5.0, x.CalcPremium(19, "female"));
        }

        [Test]
        public static void Test15()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(5.0, x.CalcPremium(29, "female"));
        }

        [Test]
        public static void Test16()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(5.0, x.CalcPremium(30, "female"));
        }

        [Test]
        public static void Test17()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(3.5, x.CalcPremium(31, "female"));
        }

        [Test]
        public static void Test18()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(3.5, x.CalcPremium(49, "female"));
        }

        [Test]
        public static void Test19()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(1.75, x.CalcPremium(50, "female"));
        }

        [Test]
        public static void Test20()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(1.75, x.CalcPremium(51, "female"));
        }

        [Test]
        public static void Test21()
        {
            InsuranceService x = new InsuranceService();
            Assert.AreEqual(0.0, x.CalcPremium(22, "evil mario"));
        }
    }
}