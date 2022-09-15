namespace DesignPatterns.BehavorialPatterns.State;

// ConcreteState class
public class RedState : State
{
    private double _serviceFee;

    public RedState(State state)
    {
        Balance = state.Balance;
        Account = state.Account;
        Initialize();
    }

    private void Initialize()
    {
        Interest = 0.0;
        LowerLimit = -100.0;
        UpperLimit = 0.0;
        _serviceFee = 15.00;
    }

    public override void Deposit(double amount)
    {
        Balance += amount;
        StateChangeCheck();
    }

    public override void Withdraw(double amount)
    {
        amount -= _serviceFee;
        Console.WriteLine("No funds available for withdrawal!");
    }

    public override void PayInterest()
    {
        // No interest is paid
    }

    private void StateChangeCheck()
    {
        if (Balance > UpperLimit)
            Account.State = new SilverState(this);
    }
}
