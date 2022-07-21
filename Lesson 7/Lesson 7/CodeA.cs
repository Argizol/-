using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    //Класс шифрует строку посредством сдвига  каждого символа на одну «алфавитную» позицию выше. (В результате такого сдвига буква А становится буквой Б)

    internal class CodeA : ICoder
    {
        public string Encoder(string str, char[] alfabet)
        {
            StringBuilder sb = new StringBuilder();
            var result = str.ToCharArray();
            char charToAppend = ' ';

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(' '))
                    sb.Append(' ');

                for (int j = 0; j < alfabet.Length; j++)
                {
                    if (result[i] == alfabet[j])
                    {
                        if (j == 32)
                        {
                            charToAppend = 'а';
                        }
                        else
                        {
                            charToAppend = alfabet[j + 1];
                        }
                        sb.Append(charToAppend);
                    }
                }
            }
            return sb.ToString();
        }

        public string Decoder(string str, char[] alfabet)
        {
            StringBuilder sb = new StringBuilder();
            var result = str.ToCharArray();
            char charToAppend = ' ';

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Equals(' '))
                    sb.Append(' ');

                for (int j = 0; j < alfabet.Length; j++)
                {
                    if (result[i] == alfabet[j])
                    {
                        if (j == 0)
                        {
                            charToAppend = 'я';
                        }
                        else
                        {
                            charToAppend = alfabet[j - 1];
                        }
                        sb.Append(charToAppend);
                    }
                }
            }
            return sb.ToString();
        }

    }
}
