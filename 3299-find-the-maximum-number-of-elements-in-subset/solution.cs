public class Solution {
    public int MaximumLength(int[] nums) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        foreach(int i in nums)
        {
            if(!numDict.ContainsKey(i))
            {
                numDict.Add(i, 0);
            }
            numDict[i]++;
        }

        int max = 1;
        if(numDict.ContainsKey(1))
        {
            int value = numDict[1];
            if(value % 2 == 0)
            {
                value -= 1;
            }
            max = Math.Max(max, value);
        }

        foreach(KeyValuePair<int, int> pair in numDict)
        {
            if(pair.Key == 1 || pair.Value < 2)
                continue;
            int currentNum = pair.Key;
            int num = 0;
            int count = pair.Value;
            while(currentNum <= 1000000000 &&  count>= 2)
            {
                num += 2;
                currentNum *= currentNum;
                count = 0;
                numDict.TryGetValue(currentNum, out count);
            }

            if(currentNum <= 1000000000 && count > 0)
            {
                num += 1;
            }    
            else
            {
                num -= 1;
            }
            max = Math.Max(max, num);
        }
        return max;
    }
}
