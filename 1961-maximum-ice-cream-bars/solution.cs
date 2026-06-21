public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);
        int count = 0;
        int sum = 0;
        int i = 0;
        while(i < costs.Length && costs[i] < coins)
        {
            sum += costs[i];
            if(sum <= coins)
                count++;
            else
                break;
            i++;
        }
        return count;
    }
}
