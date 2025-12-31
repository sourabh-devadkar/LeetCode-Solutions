public class Solution {
    public bool ValidMountainArray(int[] arr) {
        bool upPointer = true;
        bool downPointer = false;
        for(int i = 1; i < arr.Length; i++)
        {
            if(upPointer && arr[i - 1] < arr[i])
            {
                downPointer = true;
            }
            else if(downPointer && arr[i - 1] > arr[i])
            {
                upPointer = false;
                continue;
            }
            else
                return false;
                
        }
        if(!upPointer)
            return true;
        else
            return false;
    }
}
