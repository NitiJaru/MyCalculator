using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myCalculator;

namespace myWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private Calculator _calculator;
        public CalculatorController()
        {
            _calculator = new Calculator();
        }

        [HttpGet("{amount}")]
        public Response GetFirstAnswer(int amount)
        {
            var result = _calculator.FirstQuestion(amount);
            if (result == null) return new Response { IsError = true, ErrorMessage = "Input must more than zero" };

            return new Response
            {
                IsError = false,
                ErrorMessage = null,
                SecondAnswer = null,
                FirstAnswer = result
            };
        }

        [HttpGet("{amount}")]
        public Response GetSecondAnswer(int amount)
        {
            var result = _calculator.SecondQuestion(amount);
            if (string.IsNullOrWhiteSpace(result)) return new Response { IsError = true, ErrorMessage = "Input must more than zero" };

            return new Response
            {
                IsError = false,
                ErrorMessage = null,
                FirstAnswer = null,
                SecondAnswer = result,
            };
        }
    }

    public class Response
    {
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }

        public AnswerFirstQuestion FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
    }
}
