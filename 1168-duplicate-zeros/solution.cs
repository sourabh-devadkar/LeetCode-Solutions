public class Solution {
    public void DuplicateZeros(int[] arr) {
        int i = 0;
        while(i < arr.Length)
        {
            if(arr[i] == 0 && i < arr.Length - 1)
            {
                for(int j = arr.Length - 1; j > i + 1; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[i + 1] = 0;
                i++;
            }
            i++;
        }
        // int zeroCount = 0;
        // int index = 0;
        // for(int i = 0; i < arr.Length; i++)
        // {
        //     zeroCount++;
        //     if(arr[i] == 0)
        //         zeroCount++;
        //     if(zeroCount >= arr.Length)
        //         index = i;
        // }
        // int length = arr.Length - 1;
        // while(index >= 0)
        // {
        //     arr[]
        // }
    }
}
