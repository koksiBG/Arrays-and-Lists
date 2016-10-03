using System;
using System.Linq;


namespace Sum_Min_Max_First_Last_Average
{
    class Sum_Min_Max_First_Last_Average
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"First = {array.First()}");
            Console.WriteLine($"Last = {array.Last()}");
            Console.WriteLine($"Average = {array.Average()}");
        }
    }
}      