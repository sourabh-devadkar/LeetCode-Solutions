public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        int count = intervals.Length;
        for(int i = 0; i < intervals.Length; i++)
        {
            for(int j = 0; j < intervals.Length; j++)
            {
                if(i == j)
                    continue;
                
                if(intervals[i][0] >= intervals[j][0] && intervals[i][1] <= intervals[j][1])
                    {
                        count--;
                        break;
                    }
            }
        }
        return count;
    }
}