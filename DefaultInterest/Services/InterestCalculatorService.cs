using DefaultInterest.Models;

namespace DefaultInterest.Services;

public sealed class InterestCalculatorService(List<InterestRate> rates) : IInterestCalculatorService
{
    public decimal CalculateInterest(decimal debt, DateOnly fromDate, DateOnly toDate)
    {
        decimal totalInterest = 0;

        foreach (var rate in rates)
        {
            var periodStart = rate.FromDate > fromDate ? rate.FromDate : fromDate;

            var periodEnd = rate.ToDate < toDate ? rate.ToDate : toDate;

            if (periodStart > periodEnd)
            {
                break;
            }

            var days = periodEnd.DayNumber - periodStart.DayNumber + 1;

            var interest = debt * (rate.AnnualRate / 100m) * days / 365m;

            totalInterest += interest;
        }

        return Math.Round(totalInterest, 2);
    }
}
