﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Condense_Array_to_Number
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (numbers.Length > 1)
            {
                int[] condensedNumbers = new int[numbers.Length - 1];
                for (int i = 0; i < condensedNumbers.Length; i++)
                {
                    condensedNumbers[i] = numbers[i] + numbers[i + 1];
                }
                numbers = condensedNumbers;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}