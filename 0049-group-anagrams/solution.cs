public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
        foreach(string s in strs)
        {
            char[] arr = s.ToCharArray();
            arr.Sort();
            string s1 = new string(arr);
            if(dict.ContainsKey(s1))
            {
                IList<string> s1_values = dict[s1];
                s1_values.Add(s);
                dict[s1] = s1_values;
            }
            else
            {
                dict[s1] = new List<string>{s};
            }
        }
        IList<IList<string>> result = dict.Values.ToList();
        return result;
    }
}
