public class Solution {
    public int NumberOfSteps(int num) {
        int stepCount = 0;
        while(num != 0){
            stepCount++;
            if(num % 2 == 0)
                num = num/2;
            else
                num -= 1;
        }
        return stepCount;
    }
}
