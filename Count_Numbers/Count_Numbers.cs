using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Count_Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split().Select(int.Parse)
                .OrderBy(number => number)
                .ToList();
            int previousElement = numbers[0];
            int counter = 1;
            for (int currentElement = 1; currentElement < numbers.Count; currentElement++)
            {
                if (previousElement == numbers[currentElement]) counter++;

                else
                {
                    Console.WriteLine("{0} -> {1}", previousElement, counter);
                    previousElement = numbers[currentElement];
                    counter = 1;
                }
            }
            Console.WriteLine("{0} -> {1}", previousElement, counter);
        }
    }
}