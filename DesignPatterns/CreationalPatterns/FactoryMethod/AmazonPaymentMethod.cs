namespace DesignPatterns.CreationalPatterns.FactoryMethod;

// Concrete Product
public class AmazonPaymentMethod : PaymentMethod
{
    public AmazonPaymentMethod(string name)
        : base(name) { }
}
