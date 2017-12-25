using System;
using System.Linq;

public static class Kata
{
    private static int maxLimit;

    private static int minLimit;

    private static int countLimit;

    private static int[] lotteryNumbers;
    
    public static int[] ValidateBet(int countLimit, int maxLimit, string input)
    {
        SetLimit(countLimit, maxLimit);
        lotteryNumbers = Parse(input);
        return IsValid() ? lotteryNumbers.OrderBy(num => num).ToArray() : null;
    }

    private static void SetLimit(int countLimit, int maxLimit)
    {
        minLimit = 1;
        Kata.maxLimit = maxLimit;
        Kata.countLimit = countLimit;
    }

    private static bool IsValid()
    {
        return IsCountEqaulTo(countLimit) && IsWithinRange() && IsNumbersUnique();
    }

    private static int[] Parse(string input)
    {
        int isInteger;
        return input.Split(' ', ',').Where(x => x != string.Empty && int.TryParse(x, out isInteger)).Select(x => Convert.ToInt32(x)).ToArray();
    }

    private static bool IsNumbersUnique()
    {
        return lotteryNumbers.Distinct().Count() == lotteryNumbers.Length;
    }

    private static bool IsWithinRange()
    {
        return lotteryNumbers.Max() <= maxLimit && lotteryNumbers.Min() >= minLimit;
    }

    private static bool IsCountEqaulTo(int count)
    {
        return lotteryNumbers.Length == count;
    }
}

