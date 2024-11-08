namespace Specification;

public sealed class LoanApplication(double creditScore, int age, double income)
{
    public double CreditScore { get; } = creditScore;
    public int Age { get; } = age;
    public double Income { get; } = income;
}