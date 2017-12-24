using KataSMSLotteryBetValidator;
using NUnit.Framework;

namespace SMSLotteryBetValidator.Tests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void ValidateBet_Count_Is_1_Max_Is_1_numbers_are_1_Should_Return_1()
        {
            var expected = new int[] { 1 };
            var result = Kata.ValidateBet(1, 1, "1");
            Assert.AreEqual(expected, result);
        }
    }
}
