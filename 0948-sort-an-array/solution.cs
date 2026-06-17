public class Solution {
    public int[] SortArray(int[] nums) {
        if(nums == null || nums.Length <= 1) return nums;
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] nums, int left, int right)
    {
        if(left < right){
            int mid = left + (right - left) / 2;

            MergeSort(nums, left, mid);

            MergeSort(nums, mid+1, right);

            Merge(nums, left, right, mid);
        }
    }

    private void Merge(int[] nums, int left, int right, int mid)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;

        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        Array.Copy(nums, left, leftArray, 0, leftSize);
        Array.Copy(nums, mid+1, rightArray, 0, rightSize);

        int i = 0, j = 0;
        int k = left;
        while(i < leftSize && j < rightSize)
        {
            if(leftArray[i] < rightArray[j])
            {
                nums[k] = leftArray[i];
                i++;
            }
            else{
                nums[k] = rightArray[j];
                j++;
            }
            k++;
        }

        for(int x = i; x < leftSize; x++)
        {
            nums[k] = leftArray[x];
            k++;
        }

        for(int y = j; y < rightSize; y++)
        {
            nums[k] = rightArray[y];
            k++;
        }

    }
}
