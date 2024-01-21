public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];

if (-10000000 <= x && x <= 10000000 && 0 <= n && n <= 1000)
{
    for (long i = 1; i <= n; ++i)
    {
        answer[i - 1] = x * i;
    }
    return answer;
}
return null;
    }
}