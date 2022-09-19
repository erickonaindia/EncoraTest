using ConsoleApp.Model;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Sorting Operation Helper
    /// </summary>
    public static class SortingOperationsHelper
    {
        /// <summary>
        /// Sorting Operation
        /// </summary>
        /// <param name="values">StringRequest Object</param>
        /// <returns>List of strings</returns>
        /// <exception cref="Exception">Exception</exception>
        public static List<string> SortingOperations(StringRequest values)
        {
            List<string> result = new List<string>();

            if (values.N != values.Strings.Count())
                throw new Exception(ErrorMessages.Ndifferent);

            if (values.Strings.Count() == 0)
                throw new Exception(ErrorMessages.LinesNotFound);

            foreach (string value in values.Strings)
            {
                if (!value.All(Char.IsLetter) || string.IsNullOrEmpty(value))
                    throw new Exception(ErrorMessages.DifferentOfLetters);

                result.Add(ProcessString(value));
            }
            return result;
        }

        /// <summary>
        /// Process String
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns>string processed</returns>
        private static string ProcessString(string value)
        {
            string result = string.Empty;

            var charFreq = from f in value.Trim()
                           group f by f into letterFreq
                           orderby letterFreq.Key
                           select
                           (
                               Letter: letterFreq.Key,
                               Frequency: letterFreq.Count()
                           );

            var orderedList = charFreq.OrderByDescending(item => item.Frequency).ToList();

            foreach (var (_char, _frequency) in orderedList)
            {
                var builder = new StringBuilder(_char.ToString().Length + _frequency);
                for (var i = 0; i < _frequency; i++)
                {
                    builder.Append(_char).ToString();
                }
                result += builder;

            }
            return result;
        }
    }
}
