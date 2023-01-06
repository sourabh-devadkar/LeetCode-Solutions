class Solution {
    public int[] runningSum(int[] nums) {
        
        int n = nums.length;
        int arr[] = new int[n];

        int m = 0;
        for(int i=0; i<nums.length; i++){
            m += nums[i];
            arr[i] = m;
        }
        return arr;
    }
}
