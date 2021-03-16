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

        /// <summary>
        ///  "NUMBER OF STUDENTS" convert to "NumberOfStudents" 
        /// </summary>
        public static string ConvertToPascalCase(string text)
        {
            if (text.Trim().Equals(""))
                return "";

            var result = new List<string>();
            var words = text.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                var newWordString = words[i].Trim().ToLower();


                var newWord = newWordString.ToCharArray();
                newWord[0] = Char.ToUpper(newWord[0]);

                string convertedWord = new String(newWord);

                result.Add(convertedWord);

            }

            return String.Join("", result);

        }

        /// <summary>
        /// return true if only if time is in valid format dd:dd 
        /// (e.g. 19:00)
        /// </summary>
        public static bool IsValidTime(string text)
        {
            if (text == null || String.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            var hoursMinuts = text.Split(":");

            if (hoursMinuts.Length != 2)
            {
                return false;
            }
            int timeHour, timeMinut;
            try
            {
                timeHour = Convert.ToInt32(hoursMinuts[0]);
                timeMinut = Convert.ToInt32(hoursMinuts[1]);
            }
            catch (Exception)
            {
                return false;
            }

            if (timeHour < 0 || timeHour > 23)
            {
                return false;
            }

            if (timeMinut < 0 || timeMinut > 59)
            {
                return false;
            }


            return true;
        }

        public static bool IsContainDuplicates(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            numbers.Sort();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                    return true;
            }

            return false;
        }
    }
}
