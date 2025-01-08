public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int[] output = new int[nums.Length];
        int i = nums.Length - 1;
        while(i >= 0){
            if(Math.Abs(nums[left]) > Math.Abs(nums[right])){
                output[i] = nums[left] * nums[left];
                left++;
            }else{
                output[i] = nums[right] * nums[right];
                right--;
            }
            i--;
        }
        return output;
    }
}
