using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Reverse
    {
        public static string ReverseWord(string word)
        {
            char[] chars = word.ToCharArray();
            string result = string.Empty;
            StringBuilder builder = new();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                result = builder.Append(chars[i]).ToString();
            }
            return result;
        }
    }
}
