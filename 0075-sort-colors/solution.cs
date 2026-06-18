public class Solution {
    public void SortColors(int[] nums) {
        int i = 0;
        int l = 0;
        int r = nums.Length - 1;
        while(i <= r)
        {
            if(nums[i] == 0)
            {
                int temp = nums[l];
                nums[l] = nums[i];
                nums[i] = temp;
                i++;
                l++;
            }
            else if(nums[i] == 2)
            {
                int temp = nums[r];
                nums[r] = nums[i];
                nums[i] = temp;
                r--;
            }
            else{
                i++;
            }
        }
    }
}
