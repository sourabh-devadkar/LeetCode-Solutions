public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> arr = new List<string>();
        for(int i = 1; i<= n; i++){
            int a = i % 5;
            int b = i % 3;
            if(a == 0 && b == 0)
                arr.Add("FizzBuzz");
            else if(a != 0 && b == 0)
                arr.Add("Fizz");
            else if(a == 0 && b != 0)
                arr.Add("Buzz");
            else
                arr.Add(i.ToString());
        }
        return arr;
    }
}
