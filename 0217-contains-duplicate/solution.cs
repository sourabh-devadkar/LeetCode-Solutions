public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> uniqueSet = new HashSet<int>();
        foreach(int num in nums)
        {
            if(uniqueSet.Contains(num))
                return true;
            else
                uniqueSet.Add(num);
        }
        return false;
    }
}
