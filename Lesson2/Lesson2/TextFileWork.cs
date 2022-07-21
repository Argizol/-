using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class TextFileWork
    {
        public static string GetEmail(ref string words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] strings = words.Split(' ', '&');
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Trim();
                if (strings[i].Contains<char>('@'))
                {
                    stringBuilder.Append(strings[i]);
                }
            }
            return words = stringBuilder.ToString();
        }
    }
}
