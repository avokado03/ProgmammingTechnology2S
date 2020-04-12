using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnpackingString
{
    public class StringUnpacker
    {
        private bool Validate(string str)
        {
            int groupCount = str.Count(x => x == '@');
            Regex regex = new Regex(@"(@\d{1}\w{1})");
            MatchCollection matches = regex.Matches(str);
            return (matches.Count != groupCount) ? false : true;
        }

        public string Unpack(string str)
        {
            if (!Validate(str))
                throw new FormatException(@"This is an incorrect string. Use format @\d\w ");
            else
            {
                str = str.ToUpper();
                var charArray = str.ToCharArray();
                int i = 1;
                StringBuilder builder = new StringBuilder();
                while (i < charArray.Length-1)
                {
                    char currentChar = charArray[i + 1];
                    int charCount = (int)Char.GetNumericValue(charArray[i]);
                    String part = new string(currentChar, charCount);
                    builder.Append(part);
                    i += 3;
                }
                return builder.ToString();
            }
        }
    }
}
