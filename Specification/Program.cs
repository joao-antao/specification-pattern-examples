using Specification;

Console.WriteLine("Specification pattern");

var loanApplication = new LoanApplication(420, 42, 42000);

var result = new LoanApplicationUseCase().Handle(loanApplication);

Console.WriteLine($"specification result is {result}");