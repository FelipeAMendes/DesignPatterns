namespace DesignPatterns.StructuralPatterns.Facade;

// Facade
public class MortgageFacade
{
    private readonly IBankService _bankService;
    private readonly ILoanService _loanService;
    private readonly ICreditService _creditService;

    public MortgageFacade(IBankService bankService, ILoanService loanService, ICreditService creditService)
    {
        _bankService = bankService;
        _loanService = loanService;
        _creditService = creditService;
    }

    public bool IsEligible(Customer customer, int amount)
    {
        Console.WriteLine($"{customer.Name} applies for {amount:C} loan\n");

        bool eligible = CheckCreditWorthynessApplicant(customer, amount);

        return eligible;
    }

    private bool CheckCreditWorthynessApplicant(Customer customer, int amount)
    {
        return _bankService.HasSufficientSavings(customer, amount)
               && _loanService.HasNoBadLoans(customer)
               && _creditService.HasGoodCredit(customer);
    }
}
