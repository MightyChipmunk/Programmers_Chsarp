using System;

public class Solution
{
    public int target;
    public int answer = -1;
    public int[] visit = new int[1000000];
    public int solution(int x, int y, int n)
    {
        target = y;

        if (x == y)
            return 0;

        DFS(x, n, 1);

        return answer;
    }

    public void DFS(int cur, int n, int count)
    {
        if ((answer != -1 && count > answer) ||
            (visit[cur] > 0 && visit[cur] < count) ||
            cur > target) return;
        visit[cur] = count;

        if (cur + n < target)
            DFS(cur + n, n, count + 1);
        else if (cur + n == target && (answer > count || answer == -1))
            answer = count;

        if (cur * 2 < target)
            DFS(cur * 2, n, count + 1);
        else if (cur * 2 == target && (answer > count || answer == -1))
            answer = count;

        if (cur * 3 < target)
            DFS(cur * 3, n, count + 1);
        else if (cur * 3 == target && (answer > count || answer == -1))
            answer = count;
    }
}