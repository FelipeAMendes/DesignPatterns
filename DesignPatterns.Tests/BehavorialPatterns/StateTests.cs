using DesignPatterns.BehavorialPatterns.State;

namespace DesignPatterns.Tests.BehavorialPatterns;

public class StateTests
{
    [Fact]
    public void Account_DepositMethodIsCalled_ReturnsSilverState()
    {
        var account = new Account("John Bolt");

        account.Deposit(500.0);
        account.Deposit(300.0);

        Assert.IsAssignableFrom<SilverState>(account.State);
    }

    [Fact]
    public void Account_DepositMethodIsCalled_ReturnsGoldState()
    {
        var account = new Account("John Bolt");

        account.Deposit(500.0);
        account.Deposit(300.0);
        account.Deposit(550.0);

        Assert.IsAssignableFrom<GoldState>(account.State);
    }

    [Fact]
    public void Account_DepositMethodIsCalled_ReturnsRedState()
    {
        var account = new Account("John Bolt");

        account.Deposit(500.0);
        account.Deposit(300.0);
        account.Deposit(550.0);
        account.PayInterest();
        account.Withdraw(2000.00);

        Assert.IsAssignableFrom<RedState>(account.State);
    }

    [Fact]
    public void Account_DepositMethodIsCalled_ReturnsRedStateWithoutFunds()
    {
        var account = new Account("John Bolt");

        account.Deposit(500.0);
        account.Deposit(300.0);
        account.Deposit(550.0);
        account.PayInterest();
        account.Withdraw(2000.00);
        account.Withdraw(1100.00);

        Assert.IsAssignableFrom<RedState>(account.State);
        Assert.True(account.Balance < 0);
    }
}
