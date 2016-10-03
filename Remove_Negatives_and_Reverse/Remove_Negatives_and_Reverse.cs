using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Remove_Negatives_and_Reverse
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            foreach ( int num in list)
            if (num >= 0) result.Add(num);
            result.Reverse();
            if (result.Count > 0) Console.WriteLine(string.Join(" ", result));
            else Console.WriteLine("empty");  
        }
    }
}