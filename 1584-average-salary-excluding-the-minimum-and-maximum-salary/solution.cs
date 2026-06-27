public class Solution {
    public double Average(int[] salary) {
        int min = salary[0];
        int max = salary[0];
        double sum = salary[0]; 
        int n = salary.Length;
        for(int i = 1; i < n; i++)
        {
            if(salary[i] < min)
                min = salary[i];
            if(salary[i] > max)
                max = salary[i];
            sum += salary[i];
        }
        sum = sum - min - max;
        sum = sum / (n - 2);
        return double.Parse(sum.ToString("N5"));
    }
}
