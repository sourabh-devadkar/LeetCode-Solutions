public class Solution {
    public int MaxProduct(int n) {
        int firstNum  = 0, secondNum = 0;
        while(n > 0)
        {
            int temp = n % 10;
            if(temp > secondNum)
            {
                if(temp > firstNum)
                {
                    secondNum = firstNum;
                    firstNum = temp;
                }
                else
                {
                    secondNum = temp;
                }
            }
            n = n / 10;
        }
        return firstNum * secondNum;
    }
}