using ConsoleAppBasics.WorkingWithText;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ConsoleAppBasicsUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        [TestMethod]
        public void isNumbersConsecutive_numbersIsEmptyList_ReturnFalsL()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();

            var result = consecutiveOrNot.IsNumbersConsecutive(new List<int>());

            Assert.IsFalse(result);
        }
    }
}
