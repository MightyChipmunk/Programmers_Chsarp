using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int, int> size = new Dictionary<int, int>();
        int idx = 0;
        for (int i = 0; i < tangerine.Length; i++) {
            if (!size.ContainsKey(tangerine[i]))
                size.Add(tangerine[i], 0);
                
            size[tangerine[i]]++;
        }
        
        size = size.OrderByDescending(item => item.Value).ToDictionary(x => x.Key, x => x.Value);
        
        foreach (var item in size) {
            answer++;
            k -= item.Value;
            if (k <= 0)
                break;
        }
        
        return answer;
    }
}