namespace DesignPatterns.CreationalPatterns.FactoryMethod;

// Concrete Product
public class ApplePaymentMethod : PaymentMethod
{
    public ApplePaymentMethod(string name)
        : base(name) { }
}
