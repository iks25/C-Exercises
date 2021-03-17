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

        [TestMethod()]
        public void IsValidTimeTest_textNull_returnFalse()
        {
            var result = TextHelper.IsValidTime(null);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textIsEmpty_returnFalse()
        {
            var result = TextHelper.IsValidTime("");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textIsInvalitFormat_returnFalse()
        {
            var result = TextHelper.IsValidTime("2018:12:1:24:32");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textIsToBig_returnFalse()
        {
            var result = TextHelper.IsValidTime("11:20:32");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textIsValid_returnFalse()
        {
            var result = TextHelper.IsValidTime("11:20");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textHasToBigMinuts_returnFalse()
        {
            var result = TextHelper.IsValidTime("11:90");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textHasToBigHours_returnFalse()
        {
            var result = TextHelper.IsValidTime("25:30");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textHasToSmalMinuts_returnFalse()
        {
            var result = TextHelper.IsValidTime("11:-43");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsValidTimeTest_textHasToSmalHours_returnFalse()
        {
            var result = TextHelper.IsValidTime("-11:43");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ConvertToPascalCaseTest_textEmpty_returnEmptyString()
        {
            var pascalText = TextHelper.ConvertToPascalCase("");
            var result = StringAssert.Equals(pascalText, "");


            Assert.IsTrue(result);

        }

        [TestMethod()]
        public void ConvertToPascalCaseTest_textWhiteSpace_returnEmptyString()
        {
            var pascalText = TextHelper.ConvertToPascalCase("    ");
            var result = StringAssert.Equals(pascalText, "");


            Assert.IsTrue(result);


        }


        [TestMethod()]
        public void ConvertToPascalCaseTest_textOneWord_returnWordStartedByCapitalLeater()
        {
            var pascalText = TextHelper.ConvertToPascalCase("igor");
            var result = StringAssert.Equals(pascalText, "Igor");


            Assert.IsTrue(result);
        }

        public void ConvertToPascalCaseTest_textWordSeparatedBySpace_returnTextInPascaleCaseFormat()
        {
            var pascalText = TextHelper.ConvertToPascalCase("igor KoZeRski SEWeryn");
            var result = StringAssert.Equals(pascalText, "IgorKozerskiSeweryn");


            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CountVowelsTest_textEmptyWord_return0()
        {
            string text = "";
            var result = TextHelper.CountVowels(text);

            Assert.AreEqual(result, 0);
        }


        [TestMethod()]
        public void CountVowelsTest()
        {
            string text = "Igorek";
            var result = TextHelper.CountVowels(text);

            Assert.AreEqual(result, 3);
        }
    }
}
