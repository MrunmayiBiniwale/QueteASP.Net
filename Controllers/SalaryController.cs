using Microsoft.AspNetCore.Mvc;
using QueteASP.Net.Services;

namespace QueteASP.Net.Controllers
{
    [Route("api/salary")]
    public class SalaryController
    {
        private ISalaryCalculator _calculator;

        public SalaryController(ISalaryCalculator injectedCalculator)
        {
            _calculator = injectedCalculator;
        }

        [HttpGet("{yearlyAmount}")]
        public Double Get(Double yearlyAmount)
        {
            Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);
            return calculatedSalary;
        }
    }
}
