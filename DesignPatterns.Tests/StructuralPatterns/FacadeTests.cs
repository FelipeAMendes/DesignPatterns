using DesignPatterns.Tests.StructuralPatterns.Fixtures;
using Moq;

namespace DesignPatterns.Tests.StructuralPatterns;

[Collection(nameof(FacadeTestsCollection))]
public class FacadeTests
{
    private readonly FacadeTestsFixture _fixture;

    public FacadeTests(FacadeTestsFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Customer_IsEligibleMortgageFacadeIsCalled_ReturnsIsEligible()
    {
        var mortgage = _fixture.GetMortgageFacadeMock(bankSuccess: true, loanSuccess: true, creditSuccess: true);
        var customer = _fixture.GetCustomerMock();

        bool eligible = mortgage.IsEligible(customer, amount: It.IsAny<int>());

        Assert.True(eligible);
    }

    [Theory]
    [InlineData(true, false, true)]
    [InlineData(true, true, false)]
    [InlineData(false, true, true)]
    [InlineData(false, false, true)]
    [InlineData(false, false, false)]
    public void Customer_IsEligibleMortgageFacadeIsCalled_ReturnsIsNotEligible(bool bankSuccess, bool loanSuccess, bool creditSuccess)
    {
        var mortgage = _fixture.GetMortgageFacadeMock(bankSuccess, loanSuccess, creditSuccess);
        var customer = _fixture.GetCustomerMock();

        bool eligible = mortgage.IsEligible(customer, amount: It.IsAny<int>());

        Assert.False(eligible);
    }
}
