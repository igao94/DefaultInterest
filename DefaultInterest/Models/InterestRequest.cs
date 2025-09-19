namespace DefaultInterest.Models;

public sealed class InterestRequest
{
    public decimal Debt { get; set; }
    public DateOnly FromDate { get; set; }
    public DateOnly ToDate { get; set; }
}
