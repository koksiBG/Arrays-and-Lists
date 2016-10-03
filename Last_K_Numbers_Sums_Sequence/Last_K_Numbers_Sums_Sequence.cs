using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Sequence
{
    class Last_K_Numbers_Sums_Sequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            numbers[0] = 1;
            SumLastKNumbers(numbers, k);

        }

        static void SumLastKNumbers(long[] numbers, int k)
        {
            for (int currentElement = 1; currentElement < numbers.Length; currentElement++)
            {
                int startIndex = Math.Max(0, currentElement - k);
                int endIndex = currentElement - 1;
                long sum = 0;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    sum += numbers[i];
                }
                numbers[currentElement] = sum;
            }
            PrintArray(numbers);
        }

        private static void PrintArray(long[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}