public class Solution {
    public int MinCapability(int[] nums, int k) {
        int left = nums.Min(), right = nums.Max();

        while(left < right){
            int mid = (left + right) / 2;
            int robCount = 0;

            for(int i=0;i<nums.Count();i++){
                if(nums[i] <= mid){
                    robCount++;
                    i++;
                }
            }
            if(robCount >= k){
                right = mid;
            }
            else {
                left = mid + 1;
            }
        }
        return left;
    }
}