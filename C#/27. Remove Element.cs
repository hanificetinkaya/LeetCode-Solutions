// https://leetcode.com/problems/remove-element

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==val) 
            {
                nums[i]=51;
                k++;
            }
        }
        Array.Sort(nums);

        return nums.Length-k;
    }
}
