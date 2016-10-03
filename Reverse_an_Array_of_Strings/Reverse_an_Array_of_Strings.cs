using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    class Reverse_an_Array_of_Strings
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            for (int i = 0; i < text.Length / 2; i++)
            {
                string temp = text[i];
                text[i] = text[text.Length - i - 1];
                text[text.Length - i - 1] = temp;
            }
            NewMethod(text);
        }

        private static void NewMethod(string[] text)
        {
            Console.WriteLine(string.Join(" ", text));
        }
    }
}