namespace DefaultInterest.Services;

public interface IInterestCalculatorService
{
    decimal CalculateInterest(decimal debt, DateOnly fromDate, DateOnly toDate);
}
