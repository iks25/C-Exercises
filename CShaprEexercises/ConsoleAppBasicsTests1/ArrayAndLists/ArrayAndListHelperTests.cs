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
    }
}