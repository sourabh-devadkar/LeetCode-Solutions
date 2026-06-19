public class Solution {
    public int LargestAltitude(int[] gain) {
        int n = gain.Length;
        int[] altitudes = new int[n + 1];
        int result = altitudes[0] = 0;
        for(int i = 0; i < n; i++)
        {
            altitudes[i+1] = altitudes[i] + gain[i];
            if(result < altitudes[i+1])
            {
                result = altitudes[i+1];
            } 
        }
        return result;
    }
}
