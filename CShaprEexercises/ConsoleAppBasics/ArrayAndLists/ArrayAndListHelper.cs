using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    public class ArrayAndListHelper
    {
        public static String ReverseText(string text)
        {
            if (text == null || text.Length == 0)
                return "";

            var reversedTextList = new List<char>();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedTextList.Add(text[i]);
            }

            var reversedTextString = new String(reversedTextList.ToArray());
            return reversedTextString;
        }

        public static List<int> ConvertUniqueNumbersList(List<string> list)
        {
            var uniqueNumbers = new List<int>();

            if (list == null)
                return uniqueNumbers;

            foreach (var item in list)
            {
                int number;
                try
                {
                    number = Convert.ToInt32(item);
                }
                catch (Exception)
                {
                    continue;
                }

                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }

            return uniqueNumbers;

        }

        /// <summary>
        /// return list on numbers
        /// </summary>
        ///<param name="text">should be numbers separated by comma eg 1,3,2</param>
        public static List<int> ConvertToNumbers(string text)
        {
            if (text == null)
                throw new ArgumentNullException("text can not be null");

            if (text.Length == 0)
                throw new ArgumentException("text can not be empty");

            var numbers = new List<int>();
            var numbersString = text.Split(",");

            foreach (var item in numbersString)
            {
                try
                {
                    numbers.Add(Convert.ToInt32(item));
                }
                catch (Exception)
                {

                    throw new ArgumentException("invalid text");
                }
            }

            return numbers;

        }

        public static List<int> Get3SmallestNumbers(List<int> numbers)
        {

            if (numbers == null)
                throw new ArgumentNullException();

            if (numbers.Count < 5)
                throw new ArgumentOutOfRangeException
                    ("list of numbers can not be smaller then 5");

            var numbersCopy = new List<int>(numbers);

            var smallestNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int smalestNumber = numbersCopy.Min();
                smallestNumbers.Add(smalestNumber);
                numbersCopy.Remove(smalestNumber);
            }

            return smallestNumbers;



        }
    }
}
