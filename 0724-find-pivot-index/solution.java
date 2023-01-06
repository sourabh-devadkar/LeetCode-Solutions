class Solution {
    public int pivotIndex(int[] nums) {
        int n = nums.length;
        int arrLeft[] = new int[n];
        int arrRight[] = new int[n];
        arrLeft[0] = 0;
        arrRight[n-1] = 0;
        int addition = 0;
      for(int i=1; i<n-1; i++){
          addition += nums[i];
          for(int j=0; j<i; j++){
              arrLeft[i] += nums[j];
          }
          for(int k = i+1; k<n; k++){
              arrRight[i] += nums[k];
          }
      }
        arrRight[0] = addition + nums[n-1];
        arrLeft[n-1] = addition + nums[0];
      for(int l=0; l<n; l++){
          if(arrLeft[l]==arrRight[l]){
              return l;
          }
      }
        return -1;
    }
}
