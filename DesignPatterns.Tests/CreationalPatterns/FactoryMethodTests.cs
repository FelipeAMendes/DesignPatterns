using DesignPatterns.CreationalPatterns.FactoryMethod;

namespace DesignPatterns.Tests.CreationalPatterns;

public class FactoryMethodTests
{
    [Fact]
    public void AmazonPaymentMethod_CreatePaymentMethodIsCalled_ReturnsConcretePayment()
    {
        const string paymentName = nameof(AmazonPaymentMethod);
        PaymentCreator paymentCreator = new AmazonPaymentCreator();

        var result = paymentCreator.CreatePaymentMethod(paymentName);

        Assert.Equal(expected: paymentName, result.Name);
        Assert.IsAssignableFrom<AmazonPaymentMethod>(result);
    }

    [Fact]
    public void ApplePaymentMethod_CreatePaymentMethodIsCalled_ReturnsConcretePayment()
    {
        const string paymentName = nameof(ApplePaymentMethod);
        PaymentCreator paymentCreator = new ApplePaymentCreator();

        var result = paymentCreator.CreatePaymentMethod(paymentName);

        Assert.Equal(expected: paymentName, result.Name);
        Assert.IsAssignableFrom<ApplePaymentMethod>(result);
    }

    [Fact]
    public void CreditCardPaymentMethod_CreatePaymentMethodIsCalled_ReturnsConcretePayment()
    {
        const string paymentName = nameof(CreditCardPaymentMethod);
        PaymentCreator paymentCreator = new CreditCardPaymentCreator();

        var result = paymentCreator.CreatePaymentMethod(paymentName);

        Assert.Equal(expected: paymentName, result.Name);
        Assert.IsAssignableFrom<CreditCardPaymentMethod>(result);
    }

    [Fact]
    public void GooglePaymentMethod_CreatePaymentMethodIsCalled_ReturnsConcretePayment()
    {
        const string paymentName = nameof(GooglePaymentMethod);
        PaymentCreator paymentCreator = new GooglePaymentCreator();

        var result = paymentCreator.CreatePaymentMethod(paymentName);

        Assert.Equal(expected: paymentName, result.Name);
        Assert.IsAssignableFrom<GooglePaymentMethod>(result);
    }
}
