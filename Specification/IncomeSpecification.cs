namespace Specification;

public class IncomeSpecification : Specification<LoanApplication>
{
    public override bool IsSatisfiedBy(LoanApplication entity) => entity.Income >= 40000;
}