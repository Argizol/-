using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public static class Printer
    {
        public static void PrintNoMoney()
        {
            Console.WriteLine("На счете недостаточно средств \n");
        }

        public static void PrintReverseWord(string word)
        {
            Console.WriteLine($"{Reverse.ReverseWord(word)} \n");
        }
    }
}
