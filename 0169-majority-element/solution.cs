public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if(!dict.ContainsKey(num))
                dict.Add(num, 0);
            dict[num]++;
            if(dict[num] > (nums.Length / 2))
                return num;
        }
        return 0;
    }
}
