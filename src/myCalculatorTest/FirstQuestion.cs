using System;
using Xunit;
using myCalculator;

namespace myCalculatorTest
{
    public class FirstQuestion
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(15, 0, 1, 1)]
        [InlineData(20, 0, 0, 0, 1)]
        [InlineData(1000, 0, 0, 0, 0, 0, 0, 0, 1)]
        [InlineData(1700, 0, 0, 0, 0, 0, 2, 1, 1)]
        [InlineData(1776, 1, 1, 0, 1, 1, 2, 1, 1)]
        [InlineData(1736, 1, 1, 1, 1, 0, 2, 1, 1)]
        [InlineData(2686, 1, 1, 1, 1, 1, 1, 1, 2)]
        [InlineData(20666, 1, 1, 1, 0, 1, 1, 1, 20)]
        public void FirstQuestion_Successed(
            int amount,
            int expectOneBathAmount = 0,
            int expectFiveBathAmount = 0,
            int expectTenBathAmount = 0,
            int expectTwentyBathAmount = 0,
            int expectFiftyBathAmount = 0,
            int expectOneHundredBathAmount = 0,
            int expectFiveHundredBathAmount = 0,
            int expectThousandBathAmount = 0
            )
        {
            var myCal = new Calculator();
            var result = myCal.FirstQuestion(amount);

            Assert.Equal(expectOneBathAmount, result.OneBathAmount);
            Assert.Equal(expectFiveBathAmount, result.FiveBathAmount);
            Assert.Equal(expectTenBathAmount, result.TenBathAmount);
            Assert.Equal(expectTwentyBathAmount, result.TwentyBathAmount);
            Assert.Equal(expectFiftyBathAmount, result.FiftyBathAmount);
            Assert.Equal(expectOneHundredBathAmount, result.OneHundredBathAmount);
            Assert.Equal(expectFiveHundredBathAmount, result.FiveHundredBathAmount);
            Assert.Equal(expectThousandBathAmount, result.ThousandBathAmount);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void FirstQuestion_Failed(int amount)
        {
            var myCal = new Calculator();
            var result = myCal.FirstQuestion(amount);
            Assert.Null(result);
        }
    }
}
