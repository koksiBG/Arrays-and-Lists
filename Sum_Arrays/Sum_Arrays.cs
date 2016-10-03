using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Sum_Arrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int largegLength = Math.Max(firstArray.Length, secondArray.Length);
            for (int i = 0; i < largegLength; i++)
            {
                int firstValue = firstArray[i % firstArray.Length];
                int secondValue = secondArray[i % secondArray.Length];
                Console.Write("{0} ", firstValue + secondValue);
            }
        }
    }
}