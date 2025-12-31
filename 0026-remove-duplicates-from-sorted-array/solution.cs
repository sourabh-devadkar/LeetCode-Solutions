public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int num = nums[0];
        int i = 1;
        for(int j = 1; j < nums.Length; j++)
        {
            if(nums[j] != num)
            {
                nums[i] = nums[j];
                num = nums[j];
                i++;
            }
        }
        return i;
    }
}
