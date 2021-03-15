using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppBasics.WorkingWithText;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText.Tests
{
    [TestClass()]
    public class ConsecutiveOrNotTests
    {
        [TestMethod()]
        public void IsNumbersConsecutiveTest_numbersIsEmptyArray_ReturnFalse()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();

            var result = consecutiveOrNot.IsNumbersConsecutive(new List<int>());

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsNumbersConsecutiveTest_numbersIsNull_ReturnFalse()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();

            var result = consecutiveOrNot.IsNumbersConsecutive(null);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsNumbersConsecutiveTest_numbersIsOneElement_ReturnTrue()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();
            var numbers = new List<int>();
            numbers.Add(4);

            var result = consecutiveOrNot.IsNumbersConsecutive(numbers);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsNumbersConsecutiveTest_numbersIsConsecutiveIncreasing_ReturnTrue()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();
            var numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            var result = consecutiveOrNot.IsNumbersConsecutive(numbers);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsNumbersConsecutiveTest_numbersIsConsecutiveDecreasing_ReturnTrue()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();
            var numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(1);

            var result = consecutiveOrNot.IsNumbersConsecutive(numbers);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsNumbersConsecutiveTest_numbersIsnotConsecutive_ReturnFalse()
        {
            var consecutiveOrNot = new ConsecutiveOrNot();
            var numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(1);

            var result = consecutiveOrNot.IsNumbersConsecutive(numbers);

            Assert.IsFalse(result);
        }
    }
}