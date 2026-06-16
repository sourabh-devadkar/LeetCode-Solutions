public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            int need = target - nums[i];
            if(result.ContainsKey(need))
                return new int[] {result[need], i};
            result[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}
