namespace DesignPatterns.CreationalPatterns.FactoryMethod;

// AbstractCreator
public abstract class PaymentCreator
{
    // Factory Method
    public abstract PaymentMethod CreatePaymentMethod(string name);
}

// ConcreteCreator1
public class AmazonPaymentCreator : PaymentCreator
{
    public override PaymentMethod CreatePaymentMethod(string name) =>
        new AmazonPaymentMethod(name);
}

// ConcreteCreator2
public class ApplePaymentCreator : PaymentCreator
{
    public override PaymentMethod CreatePaymentMethod(string name) =>
        new ApplePaymentMethod(name);
}

// ConcreteCreator3
public class CreditCardPaymentCreator : PaymentCreator
{
    public override PaymentMethod CreatePaymentMethod(string name) =>
        new CreditCardPaymentMethod(name);
}

// ConcreteCreator4
public class GooglePaymentCreator : PaymentCreator
{
    public override PaymentMethod CreatePaymentMethod(string name) =>
        new GooglePaymentMethod(name);
}
