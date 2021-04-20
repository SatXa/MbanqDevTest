using System;
using System.Collections.Generic;

public class Q4
{
    public string description = "Write an algorithm that will return the first larger number divisible by 3 from a certain set / input number";

    public static int LargerIntDivisibleBy3FunWay(int input)
    {
        return input + (3 - (input % 3));
    }

    public static Dictionary<int, int> LargerIntDivisibleBy3_Group(int[] input)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();

        foreach (int curr in input)
        {
            result.Add(curr, LargerIntDivisibleBy3FunWay(curr));
        }

        return result;
    }

    public static int LargerIntDivisibleBy3(int input)
    {
        switch (input % 3)
        {
            case 0:
                return input + 3;
            case 1:
                return input + 2;
            case 2:
                return input + 1;
            default:
                return -1;
        }
    }
}
