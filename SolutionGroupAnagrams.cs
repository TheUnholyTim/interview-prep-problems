/***
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
***/


public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        var seen = new Dictionary<string, List<string>>();

        foreach(var anagram in strs){
            var hash = Hash(anagram);
            if (!seen.ContainsKey(hash)) {
                seen[hash] = new List<string>();
            }
            seen[hash].Add(anagram);
        }
        foreach(var pair in seen){
            result.Add(pair.Value);
        }
        return result;

    }

    private string Hash(string input) {
        var alphabet = new int[26];
        foreach (var ch in input) {
            ++alphabet[ch - 'a'];
        }
        var sb = new StringBuilder();
        for (int position = 0; position < alphabet.Length; ++position) {
            if (alphabet[position] > 0) {
                sb.Append(alphabet[position]);
                sb.Append((char)('a' + position));
            }
        }
        return sb.ToString();
    }
}
