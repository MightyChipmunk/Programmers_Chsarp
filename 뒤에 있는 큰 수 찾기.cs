using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };
        List<int> rev = new List<int>();
        int max = 0;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (i == numbers.Length - 1)
            {
                max = numbers[i];
                rev.Add(-1);
            }
            else if (numbers[i] >= max)
            {
                max = numbers[i];
                rev.Add(-1);
            }
            else if (numbers[i] >= numbers[i + 1] && numbers[i] < rev[rev.Count - 1])
            {
                rev.Add(rev[rev.Count - 1]);
            }
            else if (numbers[i] >= numbers[i + 1] && numbers[i] >= rev[rev.Count - 1])
            {
                for (int j = rev.Count - 1; j > 0; j--)
                {
                    if (rev[j] > numbers[i])
                    {
                        rev.Add(rev[j]);
                        break;
                    }
                }
            }
            else if (numbers[i] < numbers[i + 1])
            {
                rev.Add(numbers[i + 1]);
            }
        }

        rev.Reverse();
        answer = rev.ToArray();
        return answer;
    }
}