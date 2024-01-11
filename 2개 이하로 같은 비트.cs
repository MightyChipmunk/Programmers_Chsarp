using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public long[] solution(long[] numbers)
    {
        List<long> answer = new List<long>();

        foreach (long n in numbers)
        {
            answer.Add(Cal(n));
        }

        return answer.ToArray();
    }

    public long Cal(long n)
    {
        if (n == 0)
            return 1;

        int pow = 0;
        while (Math.Pow(2, pow) <= n)
        {
            pow++;
        }

        if (n == Math.Pow(2, pow) - 1)
        {
            return n + (long)Math.Pow(2, pow - 1);
        }
        else
        {
            return (long)Math.Pow(2, pow - 1) + Cal(n - (long)Math.Pow(2, pow - 1));
        }
    }
}