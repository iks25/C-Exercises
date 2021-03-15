using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBasics.WorkingWithText;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText.Tests
{
    [TestClass()]
    public class TextConverterTests
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
    }
}