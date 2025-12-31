public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        bool[] isPresent = new bool[nums.Length + 1];
        for(int i=0; i<nums.Length; i++)
        {
            isPresent[nums[i]] = true;
        }
        IList<int> result = new List<int>();
        for(int i=1; i< isPresent.Length; i++)
        {
            if(!isPresent[i])
                result.Add(i);
        }
        return result;
    }
}
