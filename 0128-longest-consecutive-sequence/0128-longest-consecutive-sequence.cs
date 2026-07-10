public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> uniqueSet = new HashSet<int>(nums);
        int maxLength = 0;
        foreach(int num in nums)
        {
            if(uniqueSet.Contains(num - 1)) continue;

            int length = 0;
            while(uniqueSet.Contains(num + length)) length++;

            if(length > maxLength) maxLength = length;
        }

        return maxLength;
    }
}