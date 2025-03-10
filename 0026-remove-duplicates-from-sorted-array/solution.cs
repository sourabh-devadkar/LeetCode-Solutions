public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        int count = 1;
        int i = 0;
        int j = 0;
        int current = 0;
        while(j < n){
            
            if(nums[i] == nums[j]){
                j++;
            }else{
                i++;
                nums[i] = nums[j];
                j++;
            }
        }    
        return i+1;
    }
}
