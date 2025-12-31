public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        for(int j = 0; j < nums.Length; j++)
        {
            if(nums[j] != 0)
            {
                nums[i] = nums[j];
                i++;
            }
        }
        for(int k = i; k < nums.Length; k++)
        {
            nums[k] = 0;
        }
    }
}
