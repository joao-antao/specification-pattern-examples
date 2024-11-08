namespace Specification;

public sealed class LoanApplicationUseCase
{
    public bool Handle(LoanApplication application)
    {
        var specification = new CreditScoreSpecification()
            .And(new AgeSpecification())
            .And(new IncomeSpecification());

        return specification.IsSatisfiedBy(application);
    }
}