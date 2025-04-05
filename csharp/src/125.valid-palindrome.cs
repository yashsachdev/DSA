/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 *
 * https://leetcode.com/problems/valid-palindrome/description/
 *
 * algorithms
 * Easy (50.40%)
 * Likes:    10196
 * Dislikes: 8529
 * Total Accepted:    4M
 * Total Submissions: 8M
 * Testcase Example:  '"A man, a plan, a canal: Panama"'
 *
 * A phrase is a palindrome if, after converting all uppercase letters into
 * lowercase letters and removing all non-alphanumeric characters, it reads the
 * same forward and backward. Alphanumeric characters include letters and
 * numbers.
 * 
 * Given a string s, return true if it is a palindrome, or false otherwise.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "A man, a plan, a canal: Panama"
 * Output: true
 * Explanation: "amanaplanacanalpanama" is a palindrome.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "race a car"
 * Output: false
 * Explanation: "raceacar" is not a palindrome.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = " "
 * Output: true
 * Explanation: s is an empty string "" after removing non-alphanumeric
 * characters.
 * Since an empty string reads the same forward and backward, it is a
 * palindrome.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 2 * 10^5
 * s consists only of printable ASCII characters.
 * 
 * 
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        int start,end;
        start = 0;
        end=s.Length-1;
        while(start<end)
        {
            while(start<end && !char.IsLetterOrDigit(s[start]))
            {
                start = start +1;
            }
            while(end>start && !char.IsLetterOrDigit(s[end]))
            {
                end = end-1;
            }
            if(char.ToLower(s[start]) != char.ToLower(s[end]))
            return false;
            start= start+1;
            end = end-1;
        }
        return true;

    }
}
// @lc code=end

