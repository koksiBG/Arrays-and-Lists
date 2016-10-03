using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Split_by_Word_Casing
    {
        static void Main(string[] args)
        {
            var separators = new char[]
              {
                ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[',']',' '
              };
            var words = Console.ReadLine().Split(separators,
              StringSplitOptions.RemoveEmptyEntries);//.ToList();
            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();
            foreach (var w in words)
            {
                var type = GetWordType(w);
                if (type == WordType.UpperCase) upperCaseList.Add(w);
                else if (type == WordType.LowerCase) lowerCaseList.Add(w);
                else mixedCaseList.Add(w);
                
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));
        }
        enum WordType { UpperCase, MixedCase, LowerCase }
        static WordType GetWordType(string word)
        {
            var lowerLetters = 0;
            var upperLetters = 0;
            foreach (var l in word)
            {
                if (char.IsUpper(l)) upperLetters++;
                else if (char.IsLower(l)) lowerLetters++;
            }
            if (upperLetters == word.Length) return WordType.UpperCase;
            if (lowerLetters == word.Length) return WordType.LowerCase;
            return WordType.MixedCase;
        }
    }
}