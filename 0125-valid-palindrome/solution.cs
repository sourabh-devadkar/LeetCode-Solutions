using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        int i = 0;
        int j = s.Length - 1;
        while(i < j)
        {
            if(s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
