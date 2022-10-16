public class Solution {
    public bool IsPalindrome(int x) {
        string xString = x.ToString();
        string first = xString.Substring(0, xString.Length/2);
        char[] arr = xString.ToCharArray();
        
        Array.Reverse(arr);
        
        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length/2);
        
        return first.Equals(second);
        
    }
}