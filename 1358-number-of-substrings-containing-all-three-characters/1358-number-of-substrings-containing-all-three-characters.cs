public class Solution {
    public int NumberOfSubstrings(string s) {
        int count = 0, left = 0, right = 0;
        int n = s.Length;
        int[] freq = new int[3];

        for(right = 0; right < n; right++)
        {
            freq[s[right] - 'a']++;
            while(freq[0] > 0 && freq[1] > 0 && freq[2] > 0)
            {
                count += n - right;
                freq[s[left] - 'a']--;
                left++;
            }
        }
        return count;
    }
}