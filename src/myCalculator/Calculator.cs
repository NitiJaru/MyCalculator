using System;

namespace myCalculator
{
    public class Calculator
    {
        // Change money amount
        public AnswerFirstQuestion FirstQuestion(int amount)
        {
            const int minimumAmount = 1;
            if (amount <= minimumAmount) return new AnswerFirstQuestion { IsError = true, ErrorMessage = "Input must more than zero" };

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
