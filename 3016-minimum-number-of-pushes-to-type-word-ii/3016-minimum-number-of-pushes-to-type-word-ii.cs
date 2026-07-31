public class Solution {
    public int MinimumPushes(string word) {
        int n = word.Length;
        if(n == 1) return 1;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char i in word)
        {
            if(!dict.ContainsKey(i))
            {
                dict.Add(i, 0);
            }
            dict[i]++;
        }

        List<char>[] freq = new List<char>[n + 1];
        for(int i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<char>();
        }

        foreach(var a in dict)
        {
            freq[a.Value].Add(a.Key);
        }

        int count = 0;
        int multiplier = 1;
        int subCount = 0;
        for(int i = n; i > 0; i--)
        {
            foreach(var a in freq[i])
            {
                count += i * multiplier;
                subCount++;
                multiplier = (subCount / 8) + 1;
            }
        }
        return count;
    }
}