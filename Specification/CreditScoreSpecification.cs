namespace Specification;

public class CreditScoreSpecification : Specification<LoanApplication>
{
    public override bool IsSatisfiedBy(LoanApplication entity) => entity.CreditScore >= 700;
}