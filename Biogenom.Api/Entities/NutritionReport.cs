namespace Biogenom.Api.Entities;

public class NutritionReport
{
    public int Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public List<NutrientIntake> Intakes { get; set; } = new();
    public List<Supplement> Supplements { get; set; } = new();
}
