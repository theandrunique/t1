using Microsoft.AspNetCore.Mvc;

namespace Biogenom.Api.Controllers;

[ApiController]
[Route("api/nutrition-assessment")]
public class NutritionAssessmentController : ControllerBase
{

    [HttpGet("report")]
    public async Task<IActionResult> GetNutritionReport()
    {
        return Ok();
    }
}
