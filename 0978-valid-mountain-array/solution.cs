public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int n = arr.Length;
        if(n < 3) return false;
        int max = 0;
        bool increase = false;
        bool decrease = false;
        for (int i=0; i<n-1; i++){
            if(arr[i] < arr[i+1] && arr[i+1] > max && (!decrease || increase)){
                max = arr[i+1];
            }else if(arr[i]> arr[i+1] && max > arr[i+1]){
                increase = false;
                decrease = true;
            }else{
                return false;
            }
        }
        if(decrease && !increase)
        return true;
        else
            return false;
    }
}
