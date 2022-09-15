namespace DesignPatterns.BehavorialPatterns.State;

// Context class
public class Account
{
    public Account(string owner)
    {
        Owner = owner;
        State = new SilverState(0.0, this);
    }

    public double Balance => State.Balance;
    public State State { get; set; }
    public string Owner { get; set; }

    public void Deposit(double amount)
    {
        State.Deposit(amount);
    }

    public void Withdraw(double amount)
    {
        State.Withdraw(amount);
    }

    public void PayInterest()
    {
        State.PayInterest();
    }
}
