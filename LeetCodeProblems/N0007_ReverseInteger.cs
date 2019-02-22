using System;

namespace LeetCodeProblems
{
    /// <summary>
    /// Given a 32-bit signed integer, reverse digits of an integer.
    /// 
    /// Note:Assume we are dealing with an environment 
    /// which could only store integers within the 32-bit signed integer range: 
    /// [−231,  231 − 1]. For the purpose of this problem, 
    /// assume that your function returns 0 when the reversed integer overflows.
    /// </summary>
    public class N0007_ReverseInteger
    {
        public int Reverse(int x)
        {
            const int numericSystem = 10;
            try
            {
                checked
                {
                    var result = 0;
                    while (x != 0)
                    {
                        result *= numericSystem;
                        var digit = x % numericSystem;
                        result += digit;
                        x /= numericSystem;
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                // Overflow case
                return 0;
            }
        }
    }
}