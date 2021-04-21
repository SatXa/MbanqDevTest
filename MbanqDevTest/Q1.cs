using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MbanqDevTest
{
    class Q1
    {
        public string description = "Write an algorithm which will, with two natural numbers, switch places without using additional variables";

        public static void Switch2Numbers(int a, int b)
        {
            Console.WriteLine($"Input: a = {a}, b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Output: a = {a}, b = {b}");
        }

        // Doesn't count because creates a new variable (int c)
        public static int SwitchTwoNumbersFail1(int a, int b, out int c)
        {
            c = b;

            return a;
        }

        /* Scrapped because creates a new variable (anonymous List)
        public static int[] SwitchTwoNumbersFail2(int a, int b)
        {
            return (new int[] { a, b }).ToList().Reverse();
        }
        */
    }
}
