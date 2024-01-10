using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] order)
    {
        int answer = 0;
        Stack<int> stack = new Stack<int>();
        int max = 0;

        for (int i = 0; i < order.Length; i++)
        {
            if (i == 0)
            {
                for (int j = 1; j < order[i]; j++)
                {
                    stack.Push(j);
                }
                answer++;
                max = order[i];
            }
            else if (stack.Count > 0 && stack.Peek() == order[i])
            {
                stack.Pop();
                answer++;
            }
            else if (order[i] > order[i - 1])
            {
                for (int j = max + 1; j < order[i]; j++)
                {
                    stack.Push(j);
                }
                answer++;
                max = order[i];
            }
            else
                break;
        }

        return answer;
    }
}
