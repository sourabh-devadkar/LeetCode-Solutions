public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        Array.Sort(arr);
        if(arr[0] != 1)
        {
            arr[0] = 1;
        }
        int max = 1;
        for(int i = 1; i < arr.Length; i++)
        {
            if(Math.Abs(arr[i] - arr[i-1]) > 1)
                arr[i] = Math.Min(arr[i], arr[i-1] + 1);
            if(max < arr[i])
                max = arr[i];
        }
        return max;
    }
}