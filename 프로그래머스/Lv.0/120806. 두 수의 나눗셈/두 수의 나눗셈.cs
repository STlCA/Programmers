using System;

public class Solution {
    public int solution(int num1, int num2) {
        float answer;        
        if ( 0< num1 && num1 <= 100&& 0< num2 && num2 <=100 )
        {
            answer = ((float)num1 / num2) * 1000;
            return (int)answer;
        }
        return 0;
    }
}