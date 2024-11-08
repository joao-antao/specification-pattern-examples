namespace Specification;

public class AgeSpecification : Specification<LoanApplication>
{
    public override bool IsSatisfiedBy(LoanApplication entity) => entity.Age is >= 18 and <= 65;
}