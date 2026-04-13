public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index = 1;
        int currentItem = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            if(currentItem != nums[i])
            {
                nums[index] = nums[i];
                currentItem = nums[i];
                index++;
            }
        }
        return index; 
    }
}
