public class Solution {
    public int MaxArea(int[] height) {
        int i = 0;
        int j = height.Length - 1;
        int area = 0;
        while(i < j)
        {
            int a = Math.Min(height[i], height[j]);
            int b = j - i;
            int tempArea = a * b;
            if(tempArea > area)
                area = tempArea;
            if(height[i] <= height[j])
                i++;
            else
                j--;
        }
        return area;
    }
}
