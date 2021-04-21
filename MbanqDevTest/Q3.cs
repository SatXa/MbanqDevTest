using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MbanqDevTest
{
    class Q3
    {
        public string description = "Write an algorithm for the Fibonacci sequence up to some set / input number";

        public static List<int> FibonacciSequence(int max)
        {
            List<int> res = new List<int>() { 1, 1 };

            while (res.Last() <= max)
            {
                if (res.TakeLast(2).Sum() <= max)
                    res.Add(res.TakeLast(2).Sum());
                else 
                    return res;
            }

            return res;
        }
    }
}
