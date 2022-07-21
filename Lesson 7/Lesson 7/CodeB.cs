using System.Text;

namespace Lesson_7
{
    // Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра,
    // расположенную в алфавите на i-й позиции с конца алфавита.
    // (Например, буква В заменяется на букву Э)

    internal class CodeB : ICoder
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
                        charToAppend = alfabet[(alfabet.Length - 1) - j];
                        sb.Append(charToAppend);
                    }
                }
            }
            return sb.ToString();
        }

        public string Decoder(string str, char[] alfabet)
        {
            return Encoder(str, alfabet);
        }
    }
}
