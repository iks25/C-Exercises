using ConsoleAppBasics.WorkingWithText;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasicsTests.WorkingWithText
{
    [TestClass]
    class ConsecutiveOrNotTest
    {

        [TestMethod]
        public void isNumbersConsecutive_numbersIsEmptyList_ReturnFalsL()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();

            var result = consecutiveOrNot.isNumbersConsecutive(new List<int>());

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void isNumbersConsecutive_numbersIsNull_ReturnFalsL()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();

            var result = consecutiveOrNot.isNumbersConsecutive(null);

            Assert.IsFalse(result);
        }

    }
}
