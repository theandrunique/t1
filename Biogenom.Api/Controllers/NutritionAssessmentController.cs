using Biogenom.Api.Data;
using Biogenom.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biogenom.Api.Controllers;

[ApiController]
[Route("api/nutrition-assessment")]
public class NutritionAssessmentController : ControllerBase
{
    private readonly AppDbContext _context;

    public NutritionAssessmentController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("report")]
    [ProducesResponseType(typeof(NutritionReport), 200)]
    public async Task<IActionResult> GetNutritionReport()
    {
        var lastReport = await _context.NutritionReports
            .Include(r => r.Intakes)
            .Include(r => r.Supplements)
            .ToListAsync();

        return Ok(lastReport);
    }
}
