public class Solution {
    public int HeightChecker(int[] heights) {
        int[] expectedHeights = new int[heights.Length];
        Array.Copy(heights, 0, expectedHeights, 0, heights.Length);
        expectedHeights = Sort(expectedHeights);
        int counter = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            if(heights[i] != expectedHeights[i])
                counter++;
        }
        return counter;
    }
    public int[] Sort(int[] heights)
    {
        Array.Sort(heights);
        return heights;
    }
}
