using System;
using System.Linq;

public static class Kata
{
    public static int[] ValidateBet(int countLimit, int maxLimit, string input)
    {
        var lottery = new Lottery(countLimit, maxLimit);
        lottery.Parse(input);
        return lottery.GetSortedNumbers();
    }
}

public class Lottery
{
    private int[] numbers;

    private readonly int countLimit;

    private readonly int maxLimit;

    private readonly int minLimit;

    public Lottery(int countLimit, int maxLimit, int minLimit = 1)
    {
        this.countLimit = countLimit;
        this.maxLimit = maxLimit;
        this.minLimit = minLimit;
    }

    public void Parse(string input)
    {
        int isInteger;
        numbers = input.Split(' ', ',').Where(x => x != string.Empty && int.TryParse(x, out isInteger)).Select(x => Convert.ToInt32(x)).ToArray();
    }

    public int[] GetSortedNumbers()
    {
        return IsValid() ? numbers.OrderBy(num => num).ToArray() : null;
    }

    public bool IsValid()
    {
        return IsCountCorrect() && IsWithinRange() && IsUnique();
    }

    private bool IsUnique()
    {
        return numbers.Distinct().Count() == numbers.Length;
    }

    private bool IsWithinRange()
    {
        return numbers.Max() <= maxLimit && numbers.Min() >= minLimit;
    }

    private bool IsCountCorrect()
    {
        return numbers.Length == countLimit;
    }
}