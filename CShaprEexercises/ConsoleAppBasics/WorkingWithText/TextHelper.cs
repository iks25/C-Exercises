using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.WorkingWithText
{
    public class TextHelper
    {
        // <summary>
        /// numbers need to be sapareded by "-" e.g. "3-5-3-1"
        /// </summary>
        /// <returns> list of numbers </returns>
        public static List<int> ConvertStringToNumberList(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                throw (new Exception("text can not be empty"));

            }

            var result = new List<int>();
            var numbersString = text.Split("-");


            foreach (var item in numbersString)
            {
                try
                {
                    result.Add(Convert.ToInt32(item));

                }
                catch (Exception)
                {

                    throw new Exception("not match scheme)");
                }
            }

            return result;
        }
    }
}
