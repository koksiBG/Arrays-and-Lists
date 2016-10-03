using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Integers
{
    class Reverse_an_Array_of_Integers
    {
        static void Main(string[] args)
        {
            int nomberOfInteger = int.Parse(Console.ReadLine());
            int[] array = new int[nomberOfInteger];
            int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                reversed[array.Length - i - 1] = array[i];
            }
            foreach (int number in reversed)
            {
                Console.Write($"{number} ");
            }
        }
    }
}