using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Domain.Entities.Calculators;

namespace WebApi.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController()
        {
            
        }

        [HttpGet]
        [Route("/api/calculations/{name}")]
        public async Task<IResult> CalculateByNames(string[] names, [FromServices]CalculatorService calculationService)
        {
            var calculations = new List<AbstractCalculator>();
            foreach (var name in names)
            {
                calculations.Add(calculationService.GetByname(name));
            }
            return calculations is not null && calculations.Count > 0
                ? Results.Ok(calculations) : Results.NotFound();
        }
    }
}
