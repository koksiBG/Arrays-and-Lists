using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_1_2_or_3_Elements
{
    class Extract_Middle_1_2_or_3_Elements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (numbers.Length == 1) Console.WriteLine(numbers[0]);
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine("{ " + numbers[numbers.Length / 2 - 1] + ", " +
                numbers[numbers.Length / 2] + " }");
            }
            else
            {
                Console.WriteLine("{ " + numbers[numbers.Length / 2 - 1] + ", " +
                numbers[numbers.Length / 2] + ", " + numbers[numbers.Length / 2 + 1] + " }");
            }
        }
    }
}