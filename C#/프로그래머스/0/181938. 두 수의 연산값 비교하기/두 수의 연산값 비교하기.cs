using System;

public class Solution {
    public int solution(int a, int b) {
        int concat = int.Parse(a.ToString() + b.ToString());
        int multi = 2 * a * b;
        
        return concat >= multi ? concat : multi;
    }
}