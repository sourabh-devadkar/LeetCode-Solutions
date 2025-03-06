public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int currentIndex = 0;
        int i = 0;
        while(i< n){
            if(nums2[i]<=nums1[currentIndex]){
                
                for(int j = nums1.Length - 1; j > currentIndex; j--){
                   nums1[j] = nums1[j-1];
                }
                
                nums1[currentIndex] = nums2[i];
                currentIndex++;
                i++;
                
            }
            else if(currentIndex >= m+i){
                 nums1[currentIndex] = nums2[i];
                currentIndex++;
                i++; 
            }else{
                currentIndex++;
            }
        }
    }
}
