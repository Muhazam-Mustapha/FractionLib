using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FractionLib;

namespace FractionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Fraction aFrac = new Fraction();

            Assert.AreEqual(aFrac.Numerator, 0);
            Assert.AreEqual(aFrac.Denominator, 1);
        }

        [TestMethod]
        public void SetterGetterTest()
        {
            Fraction aFrac = new Fraction();

            aFrac.Numerator = 4;
            Assert.AreEqual(aFrac.Numerator, 4);

            aFrac.Denominator = 7;
            Assert.AreEqual(aFrac.Denominator, 7);
        }

        [TestMethod]
        public void NormalizationTest()
        {
            Fraction aFrac = new Fraction();

            aFrac.Numerator = 5;
            aFrac.Denominator = 10;
            aFrac.Normalize();

            Assert.AreEqual(aFrac.Numerator, 1);
            Assert.AreEqual(aFrac.Denominator, 2);
        }

        [TestMethod]
        public void AdditionTest()
        {
            Fraction op1 = new Fraction();
            Fraction op2 = new Fraction();
            Fraction result;

            op1.Numerator = 1;
            op1.Denominator = 2;
            op2.Numerator = 1;
            op2.Denominator = 3;

            result = op1 + op2;

            Assert.AreEqual(result.Numerator, 5);
            Assert.AreEqual(result.Denominator, 6);
        }
    }
}
