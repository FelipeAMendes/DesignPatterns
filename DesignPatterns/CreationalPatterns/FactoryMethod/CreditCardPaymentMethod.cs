namespace DesignPatterns.CreationalPatterns.FactoryMethod;

// Concrete Product
public class CreditCardPaymentMethod : PaymentMethod
{
    public CreditCardPaymentMethod(string name)
        : base(name) { }
}
