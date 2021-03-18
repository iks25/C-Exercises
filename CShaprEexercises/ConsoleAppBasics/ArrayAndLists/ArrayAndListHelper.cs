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
    }
}
