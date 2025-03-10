public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int n = nums.Length;
        if(n == 0) return 0;
        int count = 0;
        int i=0, j = n-1;
        bool flag = false;
        while(i < j && i < n){
            if(nums[i] == val){
                if(nums[j] != val){
                    nums[i] = nums[j];
                    nums[j] = val;
                    i++;
                    flag = true;
                }
                j--;
            }else{
                i++;
            }
        }
        for(int k=0; k<n; k++){
            if(nums[k] == val){
                break;
            }else{
                count++;
            }
        }
        return count;
    }
}
