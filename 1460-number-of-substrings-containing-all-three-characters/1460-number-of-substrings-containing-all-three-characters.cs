public class Solution {
    public int NumberOfSubstrings(string s) {
        int count = 0;
        int left = 0;
        Dictionary<char, int> chart = new Dictionary<char, int>()
        {
            {'a', 0}, {'b', 0}, {'c', 0}
        };

        for(int right = 0;right<s.Length;right++){
            chart[s[right]]++;
            while(chart['a'] > 0 && chart['b'] > 0 && chart['c'] > 0){
                count += s.Length - right;
                chart[s[left]]--;
                left++;
            }
        }
        return count;
    }
}