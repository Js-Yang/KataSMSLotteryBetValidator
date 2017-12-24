using KataSMSLotteryBetValidator;
using NUnit.Framework;

namespace SMSLotteryBetValidator.Tests
{
    [TestFixture]
    public class KataTests
    {

        [TestCase(1, 1, "1", new[] { 1 }, TestName = "Count is 1 and max is 1 and input is '1' Should Return [1]")]
        [TestCase(2, 2, "2 1", new[] { 1, 2 }, TestName = "Count is 2 and max is 2 and input is '2 1' Should Return [1 2]")]
        public void ValidateBet_When_Input_is_Valid(int count, int max, string input, int[] expected)
        {
            Assert.AreEqual(expected, Kata.ValidateBet(count, max, input));
        }
    }
}
