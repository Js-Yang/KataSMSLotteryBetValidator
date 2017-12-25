using System;
using System.Linq;

public static class Kata
{
    private static int maxLimit;

    private static int minLimit = 1;

    private static int[] lotteryNumber;

    public static int[] ValidateBet(int countLimit, int maxLimit, string input)
    {
        Kata.maxLimit = maxLimit;
        var a = 0;
        lotteryNumber = input.Split(' ', ',').Where(x => x != string.Empty && int.TryParse(x, out a)).Select(x => Convert.ToInt32(x)).ToArray();
        if (IsCountEqaulTo(countLimit) && IsWithinRange() && IsUnique())
        {
            return lotteryNumber.OrderBy(num => num).ToArray();
        }

        return null;
    }

    private static bool IsUnique()
    {
        return lotteryNumber.Distinct().Count() == lotteryNumber.Length;
    }

    private static bool IsWithinRange()
    {
        return lotteryNumber.Max() <= maxLimit && lotteryNumber.Min() >= minLimit;
    }

    private static bool IsCountEqaulTo(int count)
    {
        return lotteryNumber.Length == count;
    }
}

