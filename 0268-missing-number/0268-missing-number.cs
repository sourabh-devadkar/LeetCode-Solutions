public class Solution {
    public int MissingNumber(int[] nums) {
        int[] result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0) continue;
            result[nums[i] - 1] = 1;
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(result[i] == 0)
                return i + 1;
        }
        return 0;
    }
}