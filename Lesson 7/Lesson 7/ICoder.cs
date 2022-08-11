using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
   

    internal interface ICoder
    {
        public string Encoder(string str, char[] alfabet);
        public string Decoder(string str, char[] alfabet);
    }


}
