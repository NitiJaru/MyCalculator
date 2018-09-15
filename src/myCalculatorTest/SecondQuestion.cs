using System;
using Xunit;
using myCalculator;
using System.Collections;
using System.Collections.Generic;

namespace myCalculatorTest
{
    public class SecondQuestion
    {
        [Theory]
        [InlineData(5, "2,3")]
        [InlineData(6, "1,2,3")]
        [InlineData(7, "3,4")]
        [InlineData(12, "3,4,5")]
        [InlineData(15, "7,8")]
        [InlineData(22, "4,5,6,7")]
        public void SecondQuestion_Successed(int amount, string expected)
        {
            var myCal = new Calculator();
            var result = myCal.SecondQuestion(amount);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void SecondQuestion_Failed(int amount)
        {
            var myCal = new Calculator();
            var result = myCal.SecondQuestion(amount);
            Assert.True(string.IsNullOrWhiteSpace(result));
        }
    }
}