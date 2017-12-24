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

        [Test]
        public void ValidateBet_When_Input_Is_2_1_Count_is_2_And_Max_is_2_Should_Return_1_2()
        {
            var expected = new int[] { 1, 2 };
            var result = Kata.ValidateBet(2, 2, "2 1");
            Assert.AreEqual(expected, result);
        }
    }
}
