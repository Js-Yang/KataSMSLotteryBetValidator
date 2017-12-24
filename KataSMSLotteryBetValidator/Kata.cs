using System;
using System.Linq;

namespace KataSMSLotteryBetValidator
{
    public class Kata
    {
        public static int[] ValidateBet(int count, int maxNum, string input)
        {
            var LotteryNumber = input.Split(' ', ',').Select(x => Convert.ToInt32(x)).ToArray();
            if (IsValid(count, maxNum, LotteryNumber))
            {
                return LotteryNumber.OrderBy(num => num).ToArray();
            }

            return null;
        }

        private static bool IsValid(int count, int maxNum, int[] LotteryNumber)
        {
            return LotteryNumber.Length == count && maxNum >= LotteryNumber.Max();
        }
    }
}
