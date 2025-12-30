public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int tracingCountForNums1 = 0;
        int tracingCountForNums2 = 0;
        int[] newArr = new int[m + n];
        if(n == 0)
            return;
        
        for(int i=0; i<nums1.Length; i++)
        {
            if(tracingCountForNums1 == m)
            {
                newArr[i] = nums2[tracingCountForNums2];
                tracingCountForNums2++;
            }
            else if(tracingCountForNums2 == n)
            {
                newArr[i] = nums1[tracingCountForNums1];
                tracingCountForNums1++;
            }
            else if(nums1[tracingCountForNums1] > nums2[tracingCountForNums2])
            {
                newArr[i] = nums2[tracingCountForNums2];
                tracingCountForNums2++;
            }
            else
            {
                newArr[i] = nums1[tracingCountForNums1];
                tracingCountForNums1++;
            }
        }
        Array.Copy(newArr, nums1, m+n);
    }
}
