namespace DefaultInterest.Models;

public sealed class InterestRate
{
    public DateOnly FromDate { get; set; }
    public DateOnly ToDate { get; set; }
    public decimal AnnualRate { get; set; }
}
