using Microsoft.AspNetCore.Mvc;
using Application.Services;

namespace WebApi.Controllers
{
    public class CalculationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IResult> GetByName(string name, CalculationService calculationService)
        {
            var calculation = await calculationService.GetBynameAsync(name);
            return calculation is null ? Results.NotFound() : Results.Ok(calculation);
        }
    }
}
