using System;
using System.Linq;

public static class Kata
{
    private static int maxLimit;

    private static int minLimit;

    private static int countLimit;

    private static int[] numbers;
    
    public static int[] ValidateBet(int countLimit, int maxLimit, string input)
    {
        SetLimitation(countLimit, maxLimit);
        numbers = Parse(input);
        return IsValid() ? numbers.OrderBy(num => num).ToArray() : null;
    }

    private static void SetLimitation(int countLimit, int maxLimit)
    {
        minLimit = 1;
        Kata.maxLimit = maxLimit;
        Kata.countLimit = countLimit;
    }

    private static bool IsValid()
    {
        return IsCountEqaulTo(countLimit) && IsWithinRange() && IsUnique();
    }

    private static int[] Parse(string input)
    {
        int isInteger;
        return input.Split(' ', ',').Where(x => x != string.Empty && int.TryParse(x, out isInteger)).Select(x => Convert.ToInt32(x)).ToArray();
    }

    private static bool IsUnique()
    {
        return numbers.Distinct().Count() == numbers.Length;
    }

    private static bool IsWithinRange()
    {
        return numbers.Max() <= maxLimit && numbers.Min() >= minLimit;
    }

    private static bool IsCountEqaulTo(int count)
    {
        return numbers.Length == count;
    }
}

