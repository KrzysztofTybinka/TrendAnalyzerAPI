using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Domain.Entities.Calculations;

namespace WebApi.Controllers
{
    public class CalculationController : Controller
    {
        private readonly CalculationService _calculatorService;

        public CalculationController()
        {
            
        }

        [HttpGet]
        [Route("/api/calculations/{name}")]
        public async Task<IResult> CalculateByNames(string[] names, [FromServices]CalculationService calculationService)
        {
            var calculations = new List<AbstractCalculation>();
            foreach (var name in names)
            {
                calculations.Add(calculationService.GetByname(name));
            }
            return calculations is not null && calculations.Count > 0
                ? Results.Ok(calculations) : Results.NotFound();
        }
    }
}
