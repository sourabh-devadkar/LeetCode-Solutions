public class Solution {
    public int[] SortedSquares(int[] nums) {
        int i = 0;
        int j = nums.Length - 1;
        int position = nums.Length - 1;
        int[] result = new int[nums.Length];
        while(i <= j)
        {
           int leftSquare = nums[i] * nums[i];
           int rightSquare = nums[j] * nums[j];
           if(leftSquare > rightSquare)
           {
                result[position] = leftSquare;
                i++;
           }
           else
           {
                result[position] = rightSquare;
                j--;
           }
           position--;
        }
        return result;
    }
}
