namespace DesignPatterns.BehavorialPatterns.State;

// State abstract class
public abstract class State
{
    protected double Interest;
    protected double LowerLimit;
    protected double UpperLimit;

    public Account Account { get; set; }
    public double Balance { get; set; }

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
    public abstract void PayInterest();
}
