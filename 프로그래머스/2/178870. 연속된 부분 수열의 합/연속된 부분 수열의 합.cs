using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        int[] answer = new int[2];
        Queue<int> que = new Queue<int>();      
        int sum = 0;
        int end = sequence.Length - 1;
        
        for (int i = sequence.Length - 1; i >= 0; i--) {
            sum += sequence[i];
            que.Enqueue(sequence[i]);
            if (sum == k && i > 0 && sequence[i - 1] == sequence[end]) {
                sum -= que.Dequeue();
                end--;
            }
            else if (sum == k) {
                answer[0] = i;
                answer[1] = end;
                break;
            }
            else if (sum > k) {
                sum -= que.Dequeue();
                end--;
            }
            else if (sum < k) {
                
            }
        }
        
        return answer;
    }
}