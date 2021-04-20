using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MbanqDevTest
{
    class Q5
    {
        public string description = "Write an algorithm that will calculate the N factorial of an input parameter";

        public static int Factorial(int input)
        {
            int res = 1;
            
            Enumerable.Range(1, input).ToList().ForEach(x => res = x * res);

            return res;
        }
    }
}
