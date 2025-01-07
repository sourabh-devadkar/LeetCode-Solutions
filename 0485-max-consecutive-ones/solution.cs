public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int currentCount = 0;
        foreach(int i in nums){
            if(i == 1){
                currentCount++;
                if(max < currentCount){
                    max = currentCount;
                }
            }else{
                if(max < currentCount){
                    max = currentCount;
                }
                currentCount = 0;
            }
        }
        return max;
    }
}
