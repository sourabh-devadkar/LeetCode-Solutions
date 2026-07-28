public class Solution {
    public string SmallestPalindrome(string s) {
        int n = s.Length;
        int[] arr = new int[26];
        char[] str = new char[n];

        foreach(char i in s)
        {
            arr[i - 'a']++;
        }
        int left = 0, right = n - 1;
        for(int i = 0; i < 26; i++)
        {
            while(arr[i] >= 2)
            {
                str[left++] = (char) ('a' + i);
                str[right--] = (char) ('a' + i);
                arr[i] -= 2;
            }

            if(arr[i] == 1)
            {
                str[n / 2] = (char) ('a' + i);
            }
        }
        return new string(str);
    }
}