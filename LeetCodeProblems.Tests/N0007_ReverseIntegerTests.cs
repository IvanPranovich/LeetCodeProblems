using Xunit;

namespace LeetCodeProblems.Tests
{
    public class N0007_ReverseIntegerTests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(int.MaxValue, 0)]
        [InlineData(int.MinValue, 0)]
        [InlineData(0, 0)]
        public void Reverse_Success(int testData, int expectedResult)
        {
            var solution = new N0007_ReverseInteger();

            var result = solution.Reverse(testData);

            Assert.Equal(expectedResult, result);
        }
    }
}