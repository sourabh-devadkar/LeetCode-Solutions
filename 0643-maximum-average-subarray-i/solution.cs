public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double average = 0;
        double sum = 0;
        for(int i = 0; i < k; i++)
            sum += nums[i];
        average = sum / k;
        for(int j = k; j < nums.Length; j++)
        {
            sum -= nums[j - k];
            sum += nums[j];
            double tempAverage = sum / k;
            if(tempAverage > average)
                average = tempAverage;
        }
        return average; 
    }
}
