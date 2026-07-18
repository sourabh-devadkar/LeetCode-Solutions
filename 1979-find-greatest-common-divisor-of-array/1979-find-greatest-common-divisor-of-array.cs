public class Solution {
    public int FindGCD(int[] nums) {
        int min = nums[0], max = nums[0];
        foreach(int i in nums){
            if(i < min)
            {
                min = i;
            }
            if(i > max)
            {
                max = i;
            }
        }

        for(int i = min; i >= 1; i--)
        {
            if(min % i == 0 && max % i == 0)
            {
                return i;
            }
        }
        return 1;
    }
}