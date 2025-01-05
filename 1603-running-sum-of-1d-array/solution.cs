public class Solution {
    public int[] RunningSum(int[] nums) {
        if(nums.Length == 1)
            return nums;
        int[] arr = new int[nums.Length];
        int sum = 0;
        for(int i = 0; i< nums.Length; i++){
            sum = sum + nums[i];
            arr[i] = sum;
        }
        return arr;
    }
}
