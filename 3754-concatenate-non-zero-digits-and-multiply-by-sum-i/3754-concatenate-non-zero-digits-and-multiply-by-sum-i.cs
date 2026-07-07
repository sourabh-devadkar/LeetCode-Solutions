public class Solution {
    public long SumAndMultiply(int n) {
        long sum = 0;
        long x = 0;
        int power = 0;
        while(n > 0)
        {
            int temp = n % 10;
            if(temp != 0)
            {
                sum += temp;
                x += (long) (Math.Pow(10, power) * temp);
                power++;
            }
            n = n / 10;
        }
        return x * sum;
    }
}