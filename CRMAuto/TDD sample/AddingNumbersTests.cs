using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CRMAuto.TDD_sample
{
    [TestFixture]
    class AddingNumbersTests
    {
        Calculator myCalculator = new Calculator();
        [Test]
        public void AddTwoPositiveNumbers()
        {
            int expectedResult = 100;
            int actualResult = myCalculator.Add(80, 20);
            Assert.AreEqual(expectedResult, actualResult, "The sum is incorrect");
        }

        [Test]
        public void SubtractTwoNumbers()
        {
            int expectedResult = 100;
            int actualResult = myCalculator.Subtract(120, 20);
            Assert.AreEqual(expectedResult, actualResult, "The result of subtraction is incorrect");
        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            int expectedResult = 100;
            int actualResult = myCalculator.Multiply(5, 20);
            Assert.AreEqual(expectedResult, actualResult, "The result of multiplication is incorrect");
          
        }
    }
}
