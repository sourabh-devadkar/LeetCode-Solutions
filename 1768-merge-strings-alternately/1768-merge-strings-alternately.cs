public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        int i = 0, j = 0;
        StringBuilder s = new StringBuilder();
        while(i < m && j < n)
        {
            if(i <= j){
                s.Append(word1[i]);
                i++;
            }
            else
            {
                s.Append(word2[j]);
                j++;
            }
        }
        for(int x = i; x < m; x++)
        {
            s.Append(word1[x]);
        }
        for(int y = j; y < n; y++)
        {
            s.Append(word2[y]);
        }
        return s.ToString();
    }
}