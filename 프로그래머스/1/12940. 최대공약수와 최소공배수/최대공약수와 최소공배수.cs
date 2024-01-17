using System;

public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int gcd = 1;
        for (int i = 2; i <= Math.Min(n, m); i++) {
            while (n % i == 0 && m % i == 0) {
                n /= i;
                m /= i;
                gcd *= i;
            }
        }
        answer[0] = gcd;
        answer[1] = gcd * n * m;
        
        return answer;
    }
}
