public class Solution {
    public int MinOperations(int[] nums) {
        int min = 0, count = nums.Count();
        for(int i=0;i<count-2;i++){
            if(nums[i] != 0) {
                continue;
            }
            nums[i] ^= 1;
            nums[i+1] ^= 1;
            nums[i+2] ^= 1;
            min++;
        }
        return (nums[count-1] & nums[count-2]) != 1 ? -1 : min;
    }
}