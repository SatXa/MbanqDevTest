using System;
using System.Linq;

namespace MbanqDevTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            
            const string chars = "0123456789";
            Random rand = new Random();

            // ~1s
            //string[] input = new string[rand.Next(3, 10)];
            //int maxDigitsPerNumber = 100000;

            // up to 4min
            //string[] input = new string[rand.Next(3, 3)];
            //int maxDigitsPerNumber = 1000000;

            // Don't even try this
            string[] input = new string[rand.Next(3, 10)];
            int maxDigitsPerNumber = 10000000;

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = new string(Enumerable.Repeat(chars, rand.Next(1, maxDigitsPerNumber)).Select(s => s[rand.Next(s.Length)]).ToArray());
            }

            //string[] input = new string[] { "100000000000", "31415926535", "897932384626433", "999999999" };

            string output = Q2.SumLargeNumbers(input);

            Console.WriteLine("END");
        }
    }
}
