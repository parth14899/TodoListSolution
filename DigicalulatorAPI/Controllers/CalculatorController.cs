using DigicalculatorAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigicalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calcurService;
        }

        [HttpGet("Add")]
        public ActionResult<double> Add(double a, double b)
        {
            return _calculatorService.Add(a, b);
        }

        [HttpGet("subtract")]
        public ActionResult<double> Subtract(double a, double b)
        {
            return _calculatorService.Subtract(a, b);
        }

        [HttpGet("multiply")]
        public ActionResult<double> Multiply(double a, double b)
        {
            return _calculatorService.Multiply(a, b);
        }

        [HttpGet("divide")]
        public ActionResult<double> Divide(double a, double b)
        {
            try
            {
                return _calculatorService.Divide(a, b);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
