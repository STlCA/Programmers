using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            string str = n.ToString();

            for (int i = 0; i < str.Length; i++)
            {
                answer += Convert.ToInt32(str[i] - 48);
            }
            return answer;  
        
        
    }
}