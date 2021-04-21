using System;
using System.Collections.Generic;
using System.Linq;

namespace MbanqDevTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");

            // Random number generator for tests
            Random rand = new Random();

            #region Q1: Switch two numbers w/o extra vars

            Console.WriteLine("START Q1");

            Q1.Switch2Numbers(rand.Next(1, 100), rand.Next(1, 100));

            Console.WriteLine("END Q1");

            #endregion

            #region Q2: Big number summation

            Console.WriteLine("START Q2");

            const string chars = "0123456789";

             // 3-10 x 100 thousand digits: ~1s
            string[] input = new string[rand.Next(3, 10)];
            int maxDigitsPerNumber = 100000;

            /** // 3 x 1 million digits: up to 4min
            string[] input = new string[rand.Next(3, 3)];
            int maxDigitsPerNumber = 1000000;
            */

            /** // Don't even try this it takes *so* long
            //string[] input = new string[rand.Next(3, 10)];
            //int maxDigitsPerNumber = 10000000;
            */

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = new string(Enumerable.Repeat(chars, rand.Next(1, maxDigitsPerNumber)).Select(s => s[rand.Next(s.Length)]).ToArray());
            }

            Console.WriteLine("Input: ");
            input.ToList().ForEach(x => Console.WriteLine(x.ToString()));

            string output = Q2.SumLargeNumbers_Solution1(input);

            Console.WriteLine($"Output: {output}");

            Console.WriteLine("END Q2");

            #endregion

            #region Q3: Fibonacci sequence up to input

            Console.WriteLine("START Q3");

            int input2 = rand.Next(1000, 100000);

            Console.WriteLine($"Input: {input2}");

            List<int> output2 = Q3.FibonacciSequence(input2);

            output2.ForEach(x => Console.WriteLine(x.ToString()));

            Console.WriteLine("END Q3");

            #endregion

            #region Q4: Next multiple of 3 after input

            Console.WriteLine("START Q4");

            input2 = rand.Next(1, 100000);

            Console.WriteLine($"Input: {input2}");

            int output3 = Q4.LargerIntDivisibleBy3FunWay(input2);

            Console.WriteLine($"Output: {output3}");

            Console.WriteLine("END Q4");

            #endregion

            #region Q5: N factorial

            Console.WriteLine("START Q5");

            input2 = rand.Next(1, 10);

            Console.WriteLine($"Input: {input2}");

            output3 = Q5.Factorial(input2);

            Console.WriteLine($"Output: {output3}");

            Console.WriteLine("END Q5");

            #endregion

            Console.WriteLine("END");
        }
    }
}
