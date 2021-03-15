using ConsoleAppBasics.WorkingWithText;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasicsUnitTests.WorkinWithText
{
    [TestClass]
    class ConsecutiveOrNotTest
    {



        [TestMethod]
        public void isNumbersConsecutive_numbersIsEmptyList_ReturnFalsL()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();

            var result = consecutiveOrNot.IsNumbersConsecutive(new List<int>());

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNumbersConsecutive_numbersIsNull_ReturnFalse()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();

            var result = consecutiveOrNot.IsNumbersConsecutive(null);

            Assert.IsFalse(result);
        }



    }
}
