using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string ans1 = "";
        string ans2 = "";
        
        string strA = a.ToString();
        string strB = b.ToString();
        
        ans1 += strA;
        ans1 += strB;
        
        ans2 += strB;
        ans2 += strA;
        
        int ansA = int.Parse(ans1);
        int ansB = int.Parse(ans2);
        
        if (ansA >= ansB)
            answer = ansA;
        else
            answer = ansB;
        
        return answer;
    }
}