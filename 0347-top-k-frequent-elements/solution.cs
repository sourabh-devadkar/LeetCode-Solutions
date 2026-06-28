public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int i in nums)
        {
            if(!dict.ContainsKey(i))
            {
                dict.Add(i, 0);
            }
            dict[i]++;
        }

        List<int>[] freq = new List<int>[nums.Length + 1];
        foreach(var pair in dict)
        {
            if(freq[pair.Value] == null)
                freq[pair.Value] = new List<int>();
            freq[pair.Value].Add(pair.Key);
        }

        List<int> freqElements = new List<int>();
        for(int x = freq.Length - 1; x >= 0 && freqElements.Count < k; x--)
        {
            if(freq[x] != null)
            {
                freqElements.AddRange(freq[x]);
            }
        }
        return freqElements.Take(k).ToArray();
    }
}
