using Bogus;
using DesignPatterns.StructuralPatterns.Facade;
using Moq;
using Moq.AutoMock;

namespace DesignPatterns.Tests.StructuralPatterns.Fixtures;

[CollectionDefinition(nameof(FacadeTestsCollection))]
public class FacadeTestsCollection : ICollectionFixture<FacadeTestsFixture> { }

public class FacadeTestsFixture
{
    private readonly AutoMocker _autoMocker;

    public FacadeTestsFixture()
    {
        _autoMocker = new AutoMocker();
    }

    public MortgageFacade GetMortgageFacadeMock(bool bankSuccess, bool loanSuccess, bool creditSuccess)
    {
        return new Faker<MortgageFacade>("pt_BR")
            .CustomInstantiator(_ =>
            {
                var bankMock = _autoMocker.GetMock<IBankService>();
                bankMock
                    .Setup(x => x.HasSufficientSavings(It.IsAny<Customer>(), It.IsAny<int>()))
                    .Returns(bankSuccess);

                var loanMock = _autoMocker.GetMock<ILoanService>();
                loanMock
                    .Setup(x => x.HasNoBadLoans(It.IsAny<Customer>()))
                    .Returns(loanSuccess);

                var creditMock = _autoMocker.GetMock<ICreditService>();
                creditMock
                    .Setup(x => x.HasGoodCredit(It.IsAny<Customer>()))
                    .Returns(creditSuccess);

                return new MortgageFacade(bankMock.Object, loanMock.Object, creditMock.Object);
            });
    }

    public Customer GetCustomerMock()
    {
        return new Faker<Customer>("pt_BR")
            .CustomInstantiator(x => new Customer(x.Name.FullName()));
    }
}
