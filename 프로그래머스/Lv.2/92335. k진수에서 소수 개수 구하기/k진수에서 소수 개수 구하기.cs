using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        double num = n;
        double trans = 0; // k진수로 변환된 수
        
        // k 진수로 변환
        while (num > k) {
            int i = 0;
            while (Math.Pow(k, i) < num) {
                i++;
            }
            trans += (int)(num / Math.Pow(k, i - 1)) * Math.Pow(10, i - 1);
            num = num % Math.Pow(k, i - 1);
        }
        trans += num;
        
        string s = trans.ToString();
        string[] split = s.Split('0');
        
        foreach(string st in split) {
            if (st.Length > 0 && IsPrime(Double.Parse(st)))
                answer++;
        }
        
        return answer;
    }
    
    public bool IsPrime(double n) {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++) {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}