using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace myCalculator
{
    public class Calculator
    {
        // Change money amount
        public AnswerFirstQuestion FirstQuestion(int amount)
        {
            const int minimumAmount = 1;
            if (amount < minimumAmount) return new AnswerFirstQuestion { IsError = true, ErrorMessage = "Input must more than zero" };

            var result = new AnswerFirstQuestion { IsError = false, ErrorMessage = string.Empty };
            if (amount >= 1000)
            {
                result.ThousandBathAmount = (int)amount / 1000;
                amount %= 1000;
            }
            if (amount >= 500)
            {
                result.FiveHundredBathAmount = (int)amount / 500;
                amount %= 500;
            }
            if (amount >= 100)
            {
                result.OneHundredBathAmount = (int)amount / 100;
                amount %= 100;
            }
            if (amount >= 50)
            {
                result.FiftyBathAmount = (int)amount / 50;
                amount %= 50;
            }
            if (amount >= 10)
            {
                result.TenBathAmount = (int)amount / 10;
                amount %= 10;
            }
            if (amount >= 5)
            {
                result.FiveBathAmount = (int)amount / 5;
                amount %= 5;
            }
            result.OneBathAmount = amount;
            return result;
        }

        // Summary of consecutive numbers
        public string SecondQuestion(int amount)
        {
            const int minimumAmount = 5;
            if (amount < minimumAmount) return string.Empty;

            var result = string.Empty;
            var isEven = amount % 2 == 0;
            if (isEven)
            {
                var divide = 2;
                var rs = new int[0];
                do
                {
                    rs = new int[++divide];
                    var dividedNumber = (decimal)amount / divide;
                    for (int index = 0; index < divide; index++)
                    {
                        if (index == 0) rs[index] = (int)Math.Floor(dividedNumber) - 1;
                        else rs[index] = (int)Math.Floor(dividedNumber) + (index - 1);
                    }
                } while (rs.Sum(it => it) != amount);

                for (int index = 0; index < divide; index++)
                {
                    if (index == divide - 1) result += $"{rs[index]}";
                    else result += $"{rs[index]},";
                }
            }
            else
            {
                var dividedNumber = (decimal)amount / 2;
                var first = (int)Math.Floor(dividedNumber);
                var second = (int)Math.Ceiling(dividedNumber);
                result = $"{first},{second}";
            }
            return result;
        }
    }

    public class AnswerFirstQuestion
    {
        public int ThousandBathAmount { get; set; }
        public int FiveHundredBathAmount { get; set; }
        public int OneHundredBathAmount { get; set; }
        public int FiftyBathAmount { get; set; }
        public int TenBathAmount { get; set; }
        public int FiveBathAmount { get; set; }
        public int OneBathAmount { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
    }
}
