using System;
using System.Linq;

public static class Kata
{
    public static int[] ValidateBet(int count, int maxNum, string input)
    {
        int a = 0;
        var LotteryNumber = input.Split(' ', ',').Where(x => x != string.Empty && int.TryParse(x, out a)).Select(x => Convert.ToInt32(x)).ToArray();
        if (IsValid(count, maxNum, LotteryNumber))
        {
            return LotteryNumber.OrderBy(num => num).ToArray();
        }

        return null;
    }

    private static bool IsValid(int count, int maxNum, int[] lotteryNumber)
    {
        return lotteryNumber.Length == count && maxNum >= lotteryNumber.Max() && lotteryNumber.Distinct().Count() == lotteryNumber.Length && lotteryNumber.Min() >= 1;
    }
}

