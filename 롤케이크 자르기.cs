using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] topping)
    {
        int answer = 0;
        int len = topping.Length;
        Dictionary<int, int> dictLeft = new Dictionary<int, int>();
        Dictionary<int, int> dictRight = new Dictionary<int, int>();

        for (int i = 0; i < len; i++)
        {
            if (dictRight.ContainsKey(topping[i]))
            {
                dictRight[topping[i]]++;
            }
            else
            {
                dictRight.Add(topping[i], 1);
            }
        }

        for (int i = 0; i < len; i++)
        {
            if (!dictLeft.ContainsKey(topping[i]))
            {
                dictLeft.Add(topping[i], 1);
            }

            if (dictRight[topping[i]] > 1)
            {
                dictRight[topping[i]]--;
            }
            else
            {
                dictRight.Remove(topping[i]);
            }

            if (dictLeft.Keys.Count == dictRight.Keys.Count)
            {
                answer++;
            }
        }

        return answer;
    }
}