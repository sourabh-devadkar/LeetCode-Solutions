public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int i = 0;
        int j = nums.Length - 1;
        while(i < j)
        {
            if(nums[i] % 2 != 0)
            {
                if(nums[j] % 2 == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j--;
                }
                else
                    j--;
            }
            else
                i++;
        }
        return nums;
    }
}
