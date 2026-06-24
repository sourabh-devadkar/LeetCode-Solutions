public class Solution {
    public int HeightChecker(int[] heights) {
        int[] sortedHeights = Sort(heights);
        int count = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            if(heights[i] != sortedHeights[i])
                count++;
        }
        return count;
    }
    
    public int[] Sort(int[] heights)
    {
        int[] newArr = new int[heights.Length];
        Array.Copy(heights, 0, newArr, 0, heights.Length);
        for(int i=0; i< newArr.Length - 1; i++)
        {
            for(int j=0; j<newArr.Length - 1; j++)
            {
                if(newArr[j] > newArr[j+1])
                {
                    int temp = newArr[j+1];
                    newArr[j+1] = newArr[j];
                    newArr[j] = temp;
                }
            }
        }
        return newArr;
    }
}
