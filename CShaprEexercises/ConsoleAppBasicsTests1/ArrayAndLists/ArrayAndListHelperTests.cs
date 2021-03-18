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
    }
}