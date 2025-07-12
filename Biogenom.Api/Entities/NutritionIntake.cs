namespace Biogenom.Api.Entities;

public class NutrientIntake
{
    public int Id { get; set; }
    public string NutrientName { get; set; }
    public decimal CurrentValue { get; set; }
    public decimal NormValue { get; set; }
    public decimal? FromSupplement { get; set; }
    public decimal? FromNutrition { get; set; }
    public string Unit { get; set; }
}
