public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string s = strs[0];
        for(int i = 1; i < strs.Length; i++)
        {
            if(s.Length == 0) return "";
            int j = 0;
            while(j < strs[i].Length && j < s.Length)
            {
                if(strs[i][j] != s[j])
                    break;
                j++;
            }
            s = s.Substring(0, j);
        }
        return s;
    }
}
