using NUnit.Framework;

namespace SMSLotteryBetValidator.Tests
{
    using static Kata;

    [TestFixture]
    public class KataTests
    {

        [TestCase(1, 1, "1", new[] { 1 }, TestName = "Count is 1 and max is 1 and input is '1' Should Return [1]")]
        [TestCase(2, 2, "2 1", new[] { 1, 2 }, TestName = "Count is 2 and max is 2 and input is '2 1' Should Return [1 2]")]
        [TestCase(2, 2, "1,2", new[] { 1, 2 }, TestName = "When input is '1,2' Should Return [1 2]")]
        [TestCase(3, 5, "1 , 2  4", new[] { 1, 2, 4 }, TestName = "When input include comma and space should return 1 2 4")]
        public void ValidateBet_When_Input_is_Valid(int count, int max, string input, int[] expected)
        {
            Assert.AreEqual(expected, Kata.ValidateBet(count, max, input));
        }

        [TestCase(2, 1, "1", TestName = "When numbers is smaller then count should return null")]
        [TestCase(1, 2, "1,2", TestName = "When numbers is greater then count should return null")]
        [TestCase(2, 1, "1,2", TestName = "When one of numbers is over max should return null")]
        [TestCase(2, 3, "2,2", TestName = "When numbers is not unique should return null")]
        public void ValidateBet_When_Input_is_Invalid(int count, int max, string input)
        {
            Assert.AreEqual(null, Kata.ValidateBet(count, max, input));
        }
    }
}
