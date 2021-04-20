using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace MbanqDevTest
{
    class Q2
    {
        public string description = "Write an algorithm for summing up large numbers which may have over a million digits";

        // I will assume large numbers will come in strings since they wouldn't fit in other data types
        public static string SumLargeNumbers_Solution1(string[] input)
        {
            foreach (string currNumber in input)
            {
                if (!Regex.Match(currNumber, @"\d+").Success)
                    throw new ArgumentException("Not a valid number");
            }

            int longestNumber = input.Max(x => x.Length);

            input = input.Select(x => new String(x.Reverse().ToArray())/*.PadRight(longestNumber, '0')*/).ToArray();

            string res = "";
            int carry = 0;

            for (int i = 0; i < longestNumber; i++) // i = current position inside string
            {
                int sum = 0;

                //foreach (string currNumber in input)
                //{
                //    sum += (int) Char.GetNumericValue(currNumber[i]);
                //}

                for (int j = 0; j < input.Length; j++) // current position inside string array
                {
                    try
                    {
                        sum += (int)Char.GetNumericValue(input[j][i]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        input = input.Where((val, idx) => idx != j).ToArray();
                        j--;
                    }
                    /**
                    *int digit = (int)Char.GetNumericValue(input[j][i]);
                    *
                    *if (digit == 0)
                    *{
                    *    if (!Regex.Match(input[j].Substring(i), @"0+").Success)
                    *    {
                    *        input = input.Where((val, idx) => idx != j).ToArray();
                    *        j--;
                    *    }
                    *}
                    *
                    *sum += digit;
                    **/
                }

                sum += carry;

                //res += (sum % 10).ToString();
                res += sum.ToString().Last();
                //carry = Convert.ToInt32(sum.ToString().Substring(0, sum.ToString().Length - 1));
                carry = sum / 10;
            }

            res += new String(carry.ToString().Reverse().ToArray());

            return new String(res.Reverse().ToArray()).TrimStart('0');
        }


        public static string SumLargeNumbers_Solution2(string[] input)
        {
            foreach (string currNumber in input)
            {
                if (!Regex.Match(currNumber, @"\d+").Success)
                    throw new ArgumentException("Not a valid number");
            }

            int longestNumber = input.Max(x => x.Length);

            input = input.Select(x => new String(x.Reverse().ToArray())).ToArray();

            string res = "";
            int carry = 0;

            for (int i = 0; i < longestNumber; i++) // i = current position inside string
            {
                int sum = 0;

                for (int j = 0; j < input.Length; j++) // current position inside string array
                {
                    try
                    {
                        sum += (int)Char.GetNumericValue(input[j][i]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        input = input.Where((val, idx) => idx != j).ToArray();
                        j--;
                    }
                }

                sum += carry;

                //res += (sum % 10).ToString();
                res += sum.ToString().Last();
                //carry = Convert.ToInt32(sum.ToString().Substring(0, sum.ToString().Length - 1));
                carry = sum / 10;
            }

            res += new String(carry.ToString().Reverse().ToArray());

            return new String(res.Reverse().ToArray()).TrimStart('0');
        }
    }
}
