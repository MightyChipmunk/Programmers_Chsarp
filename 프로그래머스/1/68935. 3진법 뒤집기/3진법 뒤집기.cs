using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int k = 0;
        Stack<int> stack = new Stack<int>();
        
        while(n > 0) {
            stack.Push((int)((n % Math.Pow(3, k + 1)) / Math.Pow(3, k)));
            n -= (int)(n % Math.Pow(3, k + 1));
            k++;
        }
        
        int idx = 0;
        while (stack.Count > 0) {
            answer += stack.Pop() * (int)Math.Pow(3, idx);
            idx++;
        }
        
        return answer;
    }
}