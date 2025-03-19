public class Solution {
    public int MinOperations(int[] nums) {
        int min = 0;
        for(int i=0;i<nums.Count()-2;i++){
            if(nums[i] == 0){
                for(int j=0;j<3;j++){
                    nums[i+j] = nums[i+j] == 0 ? 1 : 0;
                }
                min++;
            }
        }
        return nums.Count(a => a == 0) == 0 ? min : -1;
    }
}