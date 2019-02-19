using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems
{
    /// <summary>
    /// Given a string, find the length of the longest substring without repeating characters.
    /// </summary>
    public class N003_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            var symbols = new Dictionary<char, int>();
            var previousConcidence = -1;
            for (var i = 0; i < s.Length; i++)
            {
                var symbol = s[i];
                if (symbols.Keys.Contains(symbol))
                {
                    var length = i - previousConcidence - 1;
                    if (length > result)
                    {
                        result = length;
                    }
                    previousConcidence = symbols[symbol];
                    var removePreviousSymbols = symbols.Where(pair => pair.Value <= previousConcidence)
                        .Select(p => p.Key).ToList();
                    foreach (var removePreviousSymbol in removePreviousSymbols)
                    {
                        symbols.Remove(removePreviousSymbol);
                    }
                    symbols.Add(symbol, i);
                }
                else
                {
                    symbols.Add(symbol, i);
                }
            }
            var lastLength = s.Length - previousConcidence - 1;
            if (lastLength > result)
            {
                result = lastLength;
            }
            return result;
        }
    }
}
