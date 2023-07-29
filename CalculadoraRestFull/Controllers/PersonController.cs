using Microsoft.AspNetCore.Mvc;

namespace CalculadoraRestFull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        //ToDo: Passar metodos para serviços
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(decimal firstNumber, decimal secondNumber)
            => Ok(firstNumber + secondNumber);

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(decimal firstNumber, decimal secondNumber)
            => Ok(firstNumber - secondNumber);

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(decimal firstNumber, decimal secondNumber)
            => Ok(firstNumber * secondNumber);

        [HttpGet("divided-by/{firstNumber}/{secondNumber}")]
        public IActionResult DividedBy(decimal firstNumber, decimal secondNumber)
            => Ok(firstNumber / secondNumber);

        [HttpGet("mean")]
        public IActionResult Mean([FromQuery] decimal[] listNumber)
            => Ok(listNumber.Average());

        [HttpGet("square-root/{firstNumber}/{secondNumber}")]
        public IActionResult SquareRoot(decimal number)
            => Ok(Math.Sqrt(decimal.ToDouble(number)));

            
    }
}