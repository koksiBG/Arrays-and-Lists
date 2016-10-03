using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Rounding_Numbers_Away_from_Zero
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            RoundRealNumbersAwayFromZero(realNumbers);

        }

        static void RoundRealNumbersAwayFromZero(double[] realNumbers)
        {
            foreach (double realNumber in realNumbers)
            {
                Console.WriteLine("{0} => {0:f0}",realNumber);
            }
        }
    }
}