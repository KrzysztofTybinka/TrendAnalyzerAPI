using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Domain.Entities.Calculators;

namespace WebApi.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _calculatorService;
        private readonly OrderService _orderService;

        public CalculatorController(CalculatorService calculatorService,
            OrderService orderService)
        {
            _calculatorService = calculatorService;
            _orderService = orderService;
        }

        [HttpGet]
        [Route("/api/calculations/{name}")]
        public async Task<IResult> CalculateByNames(string name)
        {
            var calculation = _calculatorService.GetByname(name)
                .Calculate();

            return calculation is not null ? Results.Ok(calculation) : Results.NotFound();
        }
    }
}
