public class Solution {
    public void MoveZeroes(int[] nums) {
        int index = 0;
        int totalCount = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0){
                nums[index] = nums[i];
                index++;
            }
        }
        for(int k = index; k < nums.Length; k++)
        {
            nums[k] = 0;
        }
    }
}
