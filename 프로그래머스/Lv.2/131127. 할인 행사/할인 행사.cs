using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for (int i = 0; i < 10; i++) {
            if (dict.ContainsKey(discount[i])) 
                dict[discount[i]] += 1;
            else
                dict.Add(discount[i], 1);
        }
        
        if (Check(want, number, dict))
            answer++;
        
        for (int i = 10; i < discount.Length; i++) {
            if (dict.ContainsKey(discount[i])) 
                dict[discount[i]] += 1;
            else
                dict.Add(discount[i], 1);
            
            if (dict[discount[i - 10]] > 1) 
                dict[discount[i - 10]] -= 1;
            else
                dict.Remove(discount[i - 10]);
            
            if (Check(want, number, dict))
                answer++;
        }
        
        return answer;
    }
    
    public bool Check(string[] want, int[] number, Dictionary<string, int> dict) {
        bool isChecked = true;
        for (int i = 0; i < want.Length; i++) {
            if (dict.ContainsKey(want[i]) && dict[want[i]] >= number[i])
                continue;
            
            isChecked = false;
            break;
        }
        return isChecked;
    }
}