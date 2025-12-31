public class Solution {
    public int ThirdMax(int[] nums) {
        long firstMax = nums[0];
        long secondMax = long.MinValue;
        long thirdMax = long.MinValue;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > firstMax)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = nums[i];
            }
            else if(nums[i] > secondMax && nums[i] != firstMax)
            {
                thirdMax = secondMax;
                secondMax = nums[i];
            }
            else if(nums[i] > thirdMax && nums[i] != firstMax && nums[i] != secondMax)
                thirdMax = nums[i];
        }
        return thirdMax != long.MinValue ? (int) thirdMax : (int) firstMax;
    }
}
