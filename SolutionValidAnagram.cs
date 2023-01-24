/***
*
* Given two strings s and t, return true if t is an anagram of s, and false otherwise.
* An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
*
***/

public class Solution {
    public bool IsAnagram(string s, string t) {
        var sArray = s.ToLower().ToCharArray();
        var tArray = t.ToLower().ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        s = new string(sArray);
        t = new string(tArray);

        return s == t;
    }
}
