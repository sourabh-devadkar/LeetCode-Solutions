public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCount = 0;
        int temp = 0;
        foreach(int iCtr in nums)
        {
            if(iCtr == 1)
                temp++;
            else if(iCtr == 0)
            {
                if(temp > maxCount)
                    maxCount = temp;
                temp = 0;
            }
        }
        if(temp > maxCount)
            maxCount = temp;
        return maxCount;
    }
}
