public class Solution {
    public int MaxProduct(int[] nums) {
        int firstNum = 0, secondNum = 0;

        foreach(int i in nums)
        {
            if(i > secondNum)
            {
                if(i > firstNum)
                {
                    secondNum = firstNum;
                    firstNum = i;
                }
                else
                {
                    secondNum = i;
                }
            }
        }
        return (firstNum - 1) * (secondNum - 1);
    }
}