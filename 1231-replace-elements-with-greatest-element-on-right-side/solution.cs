public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int currentMax = arr[arr.Length-1];
        for(int i = arr.Length-2; i>=0; i--)
        {   int temp = arr[i];
         arr[i] = currentMax;
            if(currentMax <= temp){
                currentMax = temp;
            }
            //arr[i] = arr[i+1];
           // oldMax = currentMax;
        }    
        arr[arr.Length-1] = -1;
        return arr;
    }
}
