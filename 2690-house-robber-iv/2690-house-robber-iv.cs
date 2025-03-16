public class Solution {
    public int MinCapability(int[] nums, int k) {
        int left = nums.Min(), right = nums.Max();

        while(left < right){
            int mid = (left + right) / 2;
            int count = 0;
            for(int i=0;i<nums.Count();i++){
                if(nums[i] <= mid){
                    count++;
                    i++;
                }
            }
            if(count >= k) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}