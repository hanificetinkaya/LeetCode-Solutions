// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

public class Solution {
    public int NumberOfSteps(int num) {
       int step = 0;
       while (num != 0)
       {
         step++;
         num = num % 2 == 0 ? num / 2 : num -= 1;
       }
       return step;
    }
}
