//25ht Aug Revew this code.


public class Solution {
    public string NearestPalindromic(string n) {
        // Special cases
        if (n.Length == 1) return (int.Parse(n) - 1).ToString();
        if (n.Length == 2) return (int.Parse(n) - 1).ToString();

        long num = long.Parse(n);
        long[] candidates = new long[3];
        
        string prefix = n.Substring(0, (n.Length + 1) / 2);
        long prefixNum = long.Parse(prefix);
        
        // Generate candidates
        candidates[0] = GeneratePalindrome(prefixNum - 1, n.Length);
        candidates[1] = GeneratePalindrome(prefixNum, n.Length);
        candidates[2] = GeneratePalindrome(prefixNum + 1, n.Length);

        // Find the closest palindrome
        long closest = long.MaxValue;
        long closestDiff = long.MaxValue;

        foreach (var candidate in candidates) {
            if (candidate == num) continue;
            long diff = Math.Abs(num - candidate);
            if (diff < closestDiff || (diff == closestDiff && candidate < closest)) {
                closestDiff = diff;
                closest = candidate;
            }
        }

        return closest.ToString();
    }
    
    private long GeneratePalindrome(long prefix, int length) {
        string prefixStr = prefix.ToString();
        string palindrome = prefixStr;
        
        // Handle odd and even length palindromes
        if (length % 2 == 0) {
            palindrome += ReverseString(prefixStr);
        } else {
            palindrome += ReverseString(prefixStr.Substring(0, prefixStr.Length - 1));
        }
        
        return long.Parse(palindrome);
    }

    private string ReverseString(string s) {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
