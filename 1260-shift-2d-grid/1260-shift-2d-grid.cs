public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int m = grid.Length;
        int n = grid[0].Length;
        int[] arr = new int[m * n];
        int x = 0;
        k = k % arr.Length;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                int index = (x + k) % arr.Length;
                arr[index] = grid[i][j];
                x++;
            }
        }

        IList<IList<int>> result = new List<IList<int>>();
        IList<int> subResult = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            subResult.Add(arr[i]);
            if(subResult.Count == n)
            {
                result.Add(subResult);
                subResult = new List<int>();
            }
        }
        return result;
    }
}