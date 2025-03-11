public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int length = grid.Length;
        int[] temp = new int[length*length];

        for(int i=0;i<length;i++){
            for(int j=0;j<length;j++){
                temp[grid[i][j]-1]++;
            }
        }
        int[] result = new int[2];
        for(int i=0;i<length*length;i++){
            if(temp[i] == 2) result[0] = i+1;
            else if(temp[i] == 0) result[1] = i+1;
        }
        return result;
    }
}