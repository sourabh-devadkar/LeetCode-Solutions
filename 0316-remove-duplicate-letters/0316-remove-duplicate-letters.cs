public class Solution {
    public string RemoveDuplicateLetters(string s) {
        int[] lastOccurence = new int[26];
        Stack<char> items = new Stack<char>();
        bool[] seenChars = new bool[26];

        for(int i = 0; i < s.Length; i++)
        {
            lastOccurence[s[i] - 'a'] = i;
        }

        for(int i = 0; i < s.Length; i++)
        {
            if(seenChars[s[i] - 'a'])
                continue;

            while(items.Count > 0 && items.Peek() > s[i] && i < lastOccurence[items.Peek() - 'a'])
               seenChars[items.Pop() - 'a'] = false;

            items.Push(s[i]);
            seenChars[s[i] - 'a'] = true;
        }

        char[] arr = items.ToArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}