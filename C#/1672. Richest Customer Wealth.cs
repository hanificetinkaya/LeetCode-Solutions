// https://leetcode.com/problems/richest-customer-wealth/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int wealth=0;
        for(int i=0;i<accounts.Length;i++)
        {
            int sum=0;
            for(int j=0;j<accounts[i].Length;j++)
            {
                sum+=accounts[i][j];
            }
            if(wealth<sum) wealth=sum;
        }
        return wealth;
    }
}
