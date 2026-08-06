public class Solution {
    public int SmallestNumber(int n, int t) {
        if(t == 1) return n;
    
        while(true)
        {
            int digitProduct = GetDigitProduct(n);
            if(digitProduct % t == 0)
                return n;

            n++;
        }
    }

    private int GetDigitProduct(int n)
    {
        int product = 1;
        while(n > 0)
        {
            int lastDigit = n % 10;
            product *= lastDigit;
            n /= 10;
        }
        return product;
    }
}