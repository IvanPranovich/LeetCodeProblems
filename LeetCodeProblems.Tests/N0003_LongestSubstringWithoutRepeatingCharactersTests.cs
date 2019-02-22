using System;
using Xunit;

namespace LeetCodeProblems.Tests
{
    public class N0003_LongestSubstringWithoutRepeatingCharactersTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData(" ", 1)]
        [InlineData("123456", 6)]
        [InlineData("123456666", 6)]
        [InlineData("1111111123456", 6)]
        public void LengthOfLongestSubstring_Success(string testData, int expectedResult)
        {
            var solution = new N0003_LongestSubstringWithoutRepeatingCharacters();

            var result = solution.LengthOfLongestSubstring(testData);

            Assert.Equal(expectedResult, result);
        }
    }
}
