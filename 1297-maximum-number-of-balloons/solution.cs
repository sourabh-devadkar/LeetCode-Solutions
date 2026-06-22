public class Solution {
    public int MaxNumberOfBalloons(string text) {
      Dictionary<char, int> original = new Dictionary<char, int>();
      Dictionary<char, int> given = new Dictionary<char, int>();
      foreach(char a in "balloon")
      {
        if(!original.ContainsKey(a))
            original[a] = 0;
        original[a]++;
      }   

      foreach(char b in text)
      {
        if(!given.ContainsKey(b))
            given[b] = 0;
        given[b]++;
      }
      
      int result = int.MaxValue;
      foreach(KeyValuePair<char, int> letter in original)
      {
        if(given.ContainsKey(letter.Key))
        {
            int div = given[letter.Key] / letter.Value;
            if(div < result)
            {
                result = div;
            }
            if(result == 0)
                return 0;
        }
        else
        {
            return 0;
        }
      }
      return result;
    }
}
