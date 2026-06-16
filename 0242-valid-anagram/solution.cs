public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] result = new int[26];

        for(int i=0; i < s.Length; i++)
        {
            result[s[i] - 'a']++;
        }

        for(int j = 0; j < t.Length; j++)
        {
            result[t[j] - 'a']--;
        }
        foreach(int item in result)
        {
            if(item != 0)
                return false;
        }
        return true;
    }
}
