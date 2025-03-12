public class Solution {
    public int MaximumCount(int[] nums) {
        int neg = 0;
        int pos = 0;
        foreach(int num in nums){
            if(num < 0) neg++;
            else if(num > 0) pos++;
        }
        return Math.Max(neg, pos);
    }
}