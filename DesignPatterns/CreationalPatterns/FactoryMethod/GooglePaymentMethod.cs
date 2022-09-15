namespace DesignPatterns.CreationalPatterns.FactoryMethod;

// Concrete Product
public class GooglePaymentMethod : PaymentMethod
{
    public GooglePaymentMethod(string name)
        : base(name) { }
}
