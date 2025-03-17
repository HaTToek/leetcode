public class Solution {
    public bool DivideArray(int[] nums) {
        int[] result = new int[500];
        foreach(int num in nums){
            result[num-1]++;
        }

        foreach(int num in result){
            if(num%2 == 1) return false;
        }
        return true;
    }
}