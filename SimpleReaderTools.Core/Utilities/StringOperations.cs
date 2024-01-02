using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleReaderTools.Core.Utilities
{
    public class StringOperations
    {
        private Random _ran;
        public StringOperations()
        {
            _ran = new Random(unchecked((int)DateTime.Now.Ticks));
        }
        public static string RegularReplace(string text, string find, string replacement, bool mcase)
        {
            Regex reg = new Regex(find, mcase ? RegexOptions.None : RegexOptions.IgnoreCase);
            return reg.Replace(text, replacement);
        }

        public static string CommonReplace(string text, string find, string replacement, bool mcase)
        {
            string result = text;
            var mcaseOption = mcase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            int index = result?.IndexOf(find, mcaseOption) ?? -1;
            string ReplacedString;
            while (index > -1)
            {
                ReplacedString = $"{result.Substring(0, index)}{replacement}";
                result = $"{ReplacedString}{result.Substring(index + find.Length)}";
                index = result?.IndexOf(find, ReplacedString.Length, mcaseOption) ?? -1;
            }
            return result;
        }
        public string RandomStrings(string seeds, int length)
        {
            var str = "";
            
            for (int l = 0; l < length; l++)
            {
                str += seeds[_ran.Next(0, seeds.Length)];
            }
            return str;
        }
    }
}
