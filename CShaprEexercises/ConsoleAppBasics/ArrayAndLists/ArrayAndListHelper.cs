using System;
using System.Collections.Generic;
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
    }
}
