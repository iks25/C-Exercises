using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBasics.WorkingWithText;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText.Tests
{
    [TestClass()]
    public class TextHelperTests
    {
        [TestMethod()]
        public void ConvertStringToNumberListTest_textEmpty_ThrowExeption()
        {
            try
            {
                TextHelper.ConvertStringToNumberList("");
                Assert.Fail();
            }
            catch (Exception ex)
            {

                StringAssert.Contains(ex.Message, "empty");
            }
        }

        [TestMethod()]
        public void ConvertStringToNumberListTest_textWhiteSpace_ThrowExeption()
        {
            try
            {
                TextHelper.ConvertStringToNumberList("  ");
                Assert.Fail();
            }
            catch (Exception ex)
            {

                StringAssert.Contains(ex.Message, "empty");
            }
        }

        [TestMethod()]
        public void ConvertStringToNumberListTest_textNotNumbers_ThrowExeption()
        {
            try
            {
                TextHelper.ConvertStringToNumberList("fdsfsd");
                Assert.Fail();
            }
            catch (Exception ex)
            {

                StringAssert.Contains(ex.Message, "not match scheme");
            }
        }

        [TestMethod()]
        public void ConvertStringToNumberListTest_textCorrectTest_returnListOfNumbers()
        {
            var input = "5-4-2";
            var result = TextHelper.ConvertStringToNumberList(input);

            var expectedNumbers = new List<int>() { 5, 4, 2 };

            CollectionAssert.AreEqual(expectedNumbers, result);
        }
        [TestMethod()]
        public void ConvertStringToNumberListTest_textSingleNumber_returnListOfNumbers()
        {
            var input = "5";
            var result = TextHelper.ConvertStringToNumberList(input);

            var expectedNumbers = new List<int>() { 5 };

            CollectionAssert.AreEqual(expectedNumbers, result);
        }

        [TestMethod()]
        public void IsContainDuplicatesTest_numbersIsEmpty_returnFalse()
        {
            var result = TextHelper.IsContainDuplicates(new List<int>());

            Assert.IsFalse(result);
        }


        [TestMethod()]
        public void IsContainDuplicatesTest_numbersContainDuplicate_returnTrue()
        {
            var numbers = new List<int>() { 4, 2, 4, 8 };
            var result = TextHelper.IsContainDuplicates(numbers);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsContainDuplicatesTest_numbersNotContainDuplicate_returnFalse()
        {
            var numbers = new List<int>() { 4, 2, 14, 8 };
            var result = TextHelper.IsContainDuplicates(numbers);

            Assert.IsFalse(result);
        }
    }
}