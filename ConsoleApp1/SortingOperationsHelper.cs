using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SortingOperationsHelper
    {
        /// <summary>
        /// Sorting Operation Method
        /// </summary>
        /// <param name="value">string to sort</param>
        /// <returns>sorted string</returns>
        public static string SortingOperations(string? value)
        {
            string result = string.Empty;

            if (!value.All(Char.IsLetter) || string.IsNullOrEmpty(value))
            {
                throw new Exception();
            }

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
