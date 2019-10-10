using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pair.ViewModels;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Pair.Controllers
{
    public class CalculatorController : Controller
    {
            [HttpGet]
            [Route("/api/calculator")]
            public async Task<IActionResult> Index([FromBody] string message, [FromQuery] decimal firstNumber, [FromQuery] decimal secondNumber, [FromQuery] string operatorCal )
            {
                decimal result = 0;
                switch(operatorCal) { 
                    case "plus" :
                        result = firstNumber + secondNumber;
                        Console.WriteLine("plus"); 
                        break; 
                    case "minus" : 
                        result = firstNumber - secondNumber;
                        Console.WriteLine("minus"); 
                        break; 
                    case "multiply" : 
                        result = firstNumber * secondNumber;
                        Console.WriteLine("multiply"); 
                        break; 
                    case "divide" :
                        result = firstNumber / secondNumber;
                        Console.WriteLine("divide");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                return new OkObjectResult(new CalculatorModel());
/*
                return View(new CalculatorModel()
                {
                    Message = message,
                    FirstNumber = firstNumber,
                    SecondNumber = secondNumber,
                    Operator = operatorCal,
                    Result = result
                    
                });
*/
               
            }
    }
}