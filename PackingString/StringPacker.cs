using System;
using System.Linq;
using System.Text;

namespace PackingString
{
    public class StringPacker
    {
        public string Pack(string str)
        {
            if (str.Contains('@'))
                throw new FormatException ("This is an incorrect string. You can't use @");
            str = str.ToUpper();
            var charArr = str.ToCharArray();
            StringBuilder builder = new StringBuilder();
            int i = 0;
            int counter = 1;
            while (i < charArr.Length-1)
            {
                if (charArr[i] == charArr[i + 1])
                {
                    counter++;
                }
                else
                {
                    builder.Append("@" + counter.ToString() + charArr[i].ToString());
                    counter = 1;
                }
                i++;
            }
            builder.Append("@" + counter.ToString() + charArr[i].ToString());
            string result = builder.ToString();
            return result;
        }
    }
}
