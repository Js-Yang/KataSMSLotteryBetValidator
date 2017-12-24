using System;
using System.Linq;

namespace KataSMSLotteryBetValidator
{
    public class Kata
    {
        public static int[] ValidateBet(int count, int maxNum, string input)
        {
            var LotteryNumber = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            return LotteryNumber.OrderBy(num => num).ToArray();
        }
    }
}
