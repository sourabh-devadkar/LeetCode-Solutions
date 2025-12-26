public class Solution {
    public int FindNumbers(int[] nums) {
        int numCount = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            string num = nums[i].ToString();
            if(num.Length % 2 == 0)
                numCount ++; 
        }
        return numCount;
    }
}
