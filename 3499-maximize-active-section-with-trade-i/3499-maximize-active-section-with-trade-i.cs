public class Solution {
    public int MaxActiveSectionsAfterTrade(string s) {
        int len = s.Length, ones = 0, zeros = 0, cur0 = 0, pre0 = 0, i = 0;

        while(i < len && s[i] == '1') // pre 1s
        {
            ones++;
            i++;
        }

        while(i < len && s[i] == '0') // pre 0s
        {
            pre0++;
            i++;
        }

        while(i < len)
        {
            while(i < len && s[i] == '1')
            {
                ones++;
                i++;
            }

            if(i == len)
                break;

            while(i < len && s[i] == '0') // Find 0*1*0 pattern
            {
                cur0++;
                i++;
            }

            zeros = Math.Max(zeros, pre0+cur0);
            pre0 = cur0;
            cur0 = 0;
        }

        return ones+zeros;
    }
}