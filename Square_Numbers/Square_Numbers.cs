using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    class Square_Numbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var results = new List<int>();
            foreach (var num in nums)
            {
                if (IsExactSquare(num)) results.Add(num);
                {

                }
            }
            results.Sort();
            results.Reverse();
            Console.WriteLine(string.Join(" ", results));
        }

        static bool IsExactSquare(int num)
        {
            bool output = false;
            if (Math.Sqrt(num) == (int)Math.Sqrt(num)) output = true;
            return output;
        }
    }
}