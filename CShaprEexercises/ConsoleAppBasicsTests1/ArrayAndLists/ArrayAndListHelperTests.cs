using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBasics.ArrayAndLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists.Tests
{
    [TestClass()]
    public class ArrayAndListHelperTests
    {
        [TestMethod()]
        public void ReverseTextTest_textEmpty_returnEmptyString()
        {
            var text = "";
            var result = ArrayAndListHelper.ReverseText(text);

            Assert.AreEqual(result, "");
        }

        [TestMethod()]
        public void ReverseTextTest_textnull_returnEmptyString()
        {

            var result = ArrayAndListHelper.ReverseText(null);

            Assert.AreEqual(result, "");
        }

        [TestMethod()]
        public void ReverseTextTest_text_returnReversedText()
        {
            var text = "igor";
            var result = ArrayAndListHelper.ReverseText(text);

            Assert.AreEqual(result, "rogi");
        }

        [TestMethod()]
        public void ConvertUniqueNumbersListTest_listNull_returnEmptyArray()
        {
            var result = ArrayAndListHelper.ConvertUniqueNumbersList(null);

            Assert.AreEqual(result.Count, 0);
        }

        [TestMethod()]
        public void ConvertUniqueNumbersListTest_listEmpty_returnEmptyArray()
        {
            var list = new List<string>();
            var result = ArrayAndListHelper.ConvertUniqueNumbersList(list);

            Assert.AreEqual(result.Count, 0);
        }

        [TestMethod()]
        public void ConvertUniqueNumbersListTest_listDoNotContainNumbers_returnEmptyArray()
        {
            var list = new List<string>() { "fds", "igor", "kozerski" };
            var result = ArrayAndListHelper.ConvertUniqueNumbersList(list);

            Assert.AreEqual(result.Count, 0);
        }

        [TestMethod()]
        public void ConvertUniqueNumbersListTest_listContainNumbers_returnEmptyArray()
        {
            var list = new List<string>() { "5", "43", "kozerski", "1" };
            var result = ArrayAndListHelper.ConvertUniqueNumbersList(list);

            Assert.AreEqual(result.Count, 3);
            CollectionAssert.AreEqual(result, new List<int>() { 5, 43, 1 });
        }

        [TestMethod()]
        public void ConvertUniqueNumbersListTest_listContainNumbersWithRepetition_returnEmptyArray()
        {
            var list = new List<string>() { "5", "43", "kozerski", "1", "43", "igor" };
            var result = ArrayAndListHelper.ConvertUniqueNumbersList(list);

            Assert.AreEqual(result.Count, 3);
            CollectionAssert.AreEqual(result, new List<int>() { 5, 43, 1 });
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertToNumbersTest_textnull_ThrowException()
        {
            var result = ArrayAndListHelper.ConvertToNumbers(null);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertToNumbersTest_textEmpty_ThrowException()
        {
            var result = ArrayAndListHelper.ConvertToNumbers("");

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertToNumbersTest_textInvalidText_ThrowException()
        {
            var text = "vsfs,dsfsd,5";
            var result = ArrayAndListHelper.ConvertToNumbers(text);
        }

        [TestMethod()]
        public void ConvertToNumbersTest_validText_returnListOfNumbers()
        {
            var text = "1,5,6,5";
            var result = ArrayAndListHelper.ConvertToNumbers(text);

            var expected = new List<int>() { 1, 5, 6, 5 };

            CollectionAssert.AreEqual(result, expected);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Get3SmallestNumbersTest_numbersNull_throwExeption()
        {
            var result = ArrayAndListHelper.Get3SmallestNumbers(null);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Get3SmallestNumbersTest_numbersSizeLessthen5_throwExeption()
        {
            var numbers = new List<int>() { 2, 4, 5 };
            var result = ArrayAndListHelper.Get3SmallestNumbers(numbers);

        }

        [TestMethod()]
        public void Get3SmallestNumbersTest_validNumbers()
        {
            var numbers = new List<int>() { 2, 4, 5, 342, 1, 0 };
            var result = ArrayAndListHelper.Get3SmallestNumbers(numbers);

            var expected = new List<int>() { 0, 1, 2 };
            CollectionAssert.AreEqual(result, expected);
        }
    }
}