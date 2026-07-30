public class Solution {
    public int MinimumPushes(string word) {
        int count = 0;
        int n = word.Length;
        int i = 1;
        while(n > 0)
        {
            if(n > 8)
            {
                count += 8 * i;
                i++;
                n -= 8;
            }
            else
            {
                count += n * i;
                break;
            }
        }
        return count;
    }
}