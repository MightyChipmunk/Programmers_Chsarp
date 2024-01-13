using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long m2 = (long)money;
        for (int i = 1; i <= count; i++) {
            m2 -= (long)price * i;
        }
        
        if (m2 < 0) return -m2;
        else return 0;
    }
}