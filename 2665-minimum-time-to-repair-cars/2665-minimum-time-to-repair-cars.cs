public class Solution {
    public long RepairCars(int[] ranks, int cars) {
        long left = 1, right = (long)ranks.Min() * cars * cars;

        while(left < right){
            long mid = (left + right) / 2;
            long count = 0;
            foreach(int rank in ranks){
                count += (long)Math.Sqrt(mid / rank);
                if(count >= cars) break;
            }
            if(count >= cars) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}